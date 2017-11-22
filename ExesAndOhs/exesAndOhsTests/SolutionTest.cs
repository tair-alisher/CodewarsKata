using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExesAndOhs;

namespace exesAndOhsTests
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void XO_WhenStringHasSameAmountOFXAndO ()
        {
            Assert.AreEqual(true, Kata.XO("xo"));
            Assert.AreEqual(true, Kata.XO("xxOo"));
        }

        [TestMethod]
        public void XO_WhenStringHasNotSameAmountOfXAndO ()
        {
            Assert.AreEqual(false, Kata.XO("xxxm"));
            Assert.AreEqual(false, Kata.XO("Oo"));
            Assert.AreEqual(false, Kata.XO("ooom"));
        }
    }
}
