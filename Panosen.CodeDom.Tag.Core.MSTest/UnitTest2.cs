using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panosen.CodeDom.JavaScript;
using Panosen.CodeDom.Tag.Basic;
using Panosen.CodeDom.Tag.Basic.Engine;
using Panosen.CodeDom.Tag.Engine;
using Panosen.CodeDom.Tag.Script;
using Panosen.CodeDom.Tag.Script.Engine;
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
                .AddComponentEngine<BasicComponent>(new BasicComponentEngine())
                .AddComponentEngine<ScriptComponent>(new ScriptComponentEngine());

            new TagEngineCore().Generate(component, builder, options);

            var actual = builder.ToString();

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private string PrepareExpected()
        {
            return @"<div>
    <p>this is a test.</p>
    <script>
        console.log('ok')
    </script>
</div>";
        }

        private Component PrepareComponent()
        {
            var component = new BasicComponent();

            component.AddChild<BasicComponent>("p").SetContent("this is a test.");

            var scriptComponent = component.AddChild<ScriptComponent>();
            scriptComponent.CodeFile = PrepareJsCodeFile();

            return component;
        }

        private JsCodeFile PrepareJsCodeFile()
        {
            var jsCodeFile = new JavaScript.JsCodeFile();

            jsCodeFile.StepStatement("console.log('ok')");

            return jsCodeFile;
        }
    }
}