using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayOfTwins;

namespace ArrayOfTwinsTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Twins_WhenArrayContainsPairs ()
        {
            Assert.AreEqual(true, Kata.Twins(new int[] { 1,2,3,1,2,3 }));
        }

        [TestMethod]
        public void Twins_WhenArrayDoesNotContainParis ()
        {
            Assert.AreEqual(false, Kata.Twins(new int[] { 33, 5, 17, 5 }));
            Assert.AreEqual(false, Kata.Twins(new int[] { 2, 16, 2, 17, 2, 16 }));
        }
    }
}
