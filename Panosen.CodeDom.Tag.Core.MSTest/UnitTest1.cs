﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panosen.CodeDom.Tag.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Core.MSTest
{
    [TestClass]
    public class UnitTest1
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
            return @"<div>aaa</div>";
        }

        private Component PrepareComponent()
        {
            var component = new BasicComponent();

            component.SetContent("aaa");

            return component;
        }
    }
}