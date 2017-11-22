using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighestAndLowest;

namespace HighestAndLowestTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void HighAndLow_Test ()
        {
            Assert.AreEqual("24 -9", Kata.HighAndLow("8 3 -5 24 -1 0 0 -9 4 7 4 -4"));
        }
    }
}
