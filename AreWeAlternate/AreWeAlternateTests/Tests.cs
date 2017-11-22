using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreWeAlternate;

namespace AreWeAlternateTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ShouldReturnTrue ()
        {
            Assert.AreEqual(true, Kata.IsAlt("amazon"));
            Assert.AreEqual(true, Kata.IsAlt("banana"));
        }

        [TestMethod]
        public void ShouldReturnFalse ()
        {
            Assert.AreEqual(false, Kata.IsAlt("apple"));
        }
    }
}
