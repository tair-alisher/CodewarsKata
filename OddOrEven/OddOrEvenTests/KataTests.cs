using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OddOrEven;

namespace OddOrEvenTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void OddOrEven_EdgeTests ()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 1 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { }));
        }

        [TestMethod]
        public void OddOrEven_EvenTests ()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, 1, 5 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, 1, 3 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 1023, 1, 2 }));
        }

        [TestMethod]
        public void OddOrEven_NegativeEvenTests ()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, -1, -5 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, -1, -3 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { -1023, 1, -2 }));
        }

        [TestMethod]
        public void OddOrEven_OddTests ()
        {
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, 2 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, 4 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 1023, 1, 3 }));
        }

        [TestMethod]
        public void OddOrEven_NegativeOddTests ()
        {
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, -1, 2 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, -4 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { -1023, -1, 3 }));
        }
    }
}
