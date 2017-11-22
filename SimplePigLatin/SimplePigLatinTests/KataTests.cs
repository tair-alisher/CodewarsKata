using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplePigLatin;

namespace SimplePigLatinTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void PigIt_Tests ()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }
    }
}
