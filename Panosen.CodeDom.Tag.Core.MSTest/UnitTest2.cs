using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panosen.CodeDom.JavaScript;
using Panosen.CodeDom.Tag.Engine;
using Panosen.CodeDom.Tag.Html;
using Panosen.CodeDom.Tag.Html.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Core.MSTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var component = PrepareComponent();

            var builder = new StringBuilder();

            var options = new GenerateOptions()
                .AddHtmlComponentEngine();

            new TagEngineCore().Generate(component, builder, options);

            var actual = builder.ToString();

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private static string PrepareExpected()
        {
            return @"<div>
    <p>this is a test.</p>
    <img src=""assrc"" alt=""asalt"" />
    <script>
        console.log('ok')
    </script>
</div>";
        }

        private static Component PrepareComponent()
        {
            var component = new BasicComponent();

            component.AddChild<BasicComponent>("p").SetContent("this is a test.");

            component.AddChild<ImgComponent>().SetSrc("assrc").SetAlt("asalt");

            var scriptComponent = component.AddChild<ScriptComponent>();
            scriptComponent.CodeFile = PrepareJsCodeFile();

            return component;
        }

        private static JsCodeFile PrepareJsCodeFile()
        {
            var jsCodeFile = new JavaScript.JsCodeFile();

            jsCodeFile.StepStatement("console.log('ok')");

            return jsCodeFile;
        }
    }
}