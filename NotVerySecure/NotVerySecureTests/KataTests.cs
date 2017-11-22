using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NotVerySecure;

namespace NotVerySecureTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Alphanumeric_WhenInputValueIsSecure ()
        {
            Assert.AreEqual(true, Kata.Alphanumeric("Mazinkaiser"));
            Assert.AreEqual(true, Kata.Alphanumeric("Passw0rd"));
        }

        [TestMethod]
        public void Alphanumeric_WhenInputValueIsNotCorerct ()
        {
            Assert.AreEqual(false, Kata.Alphanumeric("hello world_"));
            Assert.AreEqual(false, Kata.Alphanumeric("      "));
        }
    }
}
