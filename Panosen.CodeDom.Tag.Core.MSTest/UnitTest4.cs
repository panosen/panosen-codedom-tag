using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panosen.CodeDom.Tag.Basic;
using Panosen.CodeDom.Tag.Basic.Engine;
using Panosen.CodeDom.Tag.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Core.MSTest
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            var component = PrepareComponent();

            var builder = new StringBuilder();

            var options = new GenerateOptions()
                .AddComponentEngine<BasicComponent>(new BasicComponentEngine());

            new TagEngineCore().Generate(component, builder, options);

            var actual = builder.ToString();

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private string PrepareExpected()
        {
            return @"<div>aaa</div>
<div>aaa</div>
<div>aaa</div>";
        }

        private List<Component> PrepareComponent()
        {
            List<Component> components = new List<Component>();

            for (int i = 0; i < 3; i++)
            {
                var component = new BasicComponent();
                component.SetContent("aaa");
                components.Add(component);
            }

            return components;
        }
    }
}