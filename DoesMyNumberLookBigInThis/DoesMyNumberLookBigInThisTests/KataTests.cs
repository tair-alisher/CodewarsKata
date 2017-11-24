using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoesMyNumberLookBigInThis;

namespace DoesMyNumberLookBigInThisTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Narcissistic_WhenInputNumberIsNarcissistic ()
        {
            Assert.AreEqual(true, Kata.Narcissistic(1), "1 is narcissistic");
            Assert.AreEqual(true, Kata.Narcissistic(371), "371 is narcissistic");
        }

        [TestMethod]
        public void Narcissistic_WhenInputNumberIsNotNarcissistic ()
        {
            Assert.AreEqual(false, Kata.Narcissistic(756), "756 is not narcissistic");
        }
    }
}
