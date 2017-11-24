using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersInStrings;

namespace NumbersInStringsTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Solve_Tests ()
        {
            Assert.AreEqual(695, Kata.Solve("gh12cdy695m1"));
            Assert.AreEqual(9, Kata.Solve("2ti9iei7qhr5"));
            Assert.AreEqual(61, Kata.Solve("vih61w8oohj5"));
            Assert.AreEqual(42, Kata.Solve("f7g42g16hcu5"));
            Assert.AreEqual(85, Kata.Solve("lu1j8qbbb85"));
        }
    }
}
