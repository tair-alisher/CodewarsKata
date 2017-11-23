using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoubleCola;

namespace DoubleColaTests
{
    [TestClass]
    public class KataTests
    {
        string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };

        [TestMethod]
        public void WhoIsNext_WhenInputValueIsLessThanNamesArrayLength ()
        {
            Assert.AreEqual("Sheldon", Kata.WhoIsNext(names, 1));
        }

        [TestMethod]
        public void WhoIsNext_WhenInputValueIsMoreThanNamesArrayLength ()
        {
            Assert.AreEqual("Sheldon", Kata.WhoIsNext(names, 6));
        }
    }
}
