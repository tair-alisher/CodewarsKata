using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakCamelCase;

namespace BreakCamelCaseTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestCase ()
        {
            Assert.AreEqual("camel Casing", Kata.BreakCamelCase("camelCasing"));
            Assert.AreEqual("camel Casing Test", Kata.BreakCamelCase("camelCasingTest"));
        }
    }
}
