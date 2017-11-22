using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreetMe;

namespace GreetMeTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Greet_Test ()
        {
            Assert.AreEqual("Hello Riley!", Kata.Greet("riley"));
        }
    }
}
