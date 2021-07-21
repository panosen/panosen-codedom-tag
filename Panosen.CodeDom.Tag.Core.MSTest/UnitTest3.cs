using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panosen.CodeDom.Tag.Engine;
using Panosen.CodeDom.Tag.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Core.MSTest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            var component = PrepareComponent();

            var builder = new StringBuilder();

            new TagEngineCore().Generate(component, builder);

            var actual = builder.ToString();

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private string PrepareExpected()
        {
            return @"<div>
    <div>aaa</div>
    <p>aaa</p>
</div>";
        }

        private Component PrepareComponent()
        {
            var component = new BasicComponent();

            component.AddChild<BasicComponent>().SetContent("aaa");
            component.AddChild<PComponent>().SetContent("aaa");

            return component;
        }
    }
}