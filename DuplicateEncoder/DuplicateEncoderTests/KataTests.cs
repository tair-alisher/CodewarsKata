using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DuplicateEncoder;

namespace DuplicateEncoderTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void DuplicateEncode_WhenInputValueIsCapitalize ()
        {
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
        }

        [TestMethod]
        public void DuplicateEncode_Tests ()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
        }
    }
}
