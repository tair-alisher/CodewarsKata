using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FnidTheMiddleElement;

namespace FindTheMiddleElementTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Gimme_Tests ()
        {
            Assert.AreEqual(0, Kata.Gimme(new double[] { 2, 3, 1 }));
            Assert.AreEqual(1, Kata.Gimme(new double[] { 5, 10, 14 }));
        }
    }
}
