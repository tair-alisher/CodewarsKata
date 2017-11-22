using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestWord;

namespace ShortestWordTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void FindShort_SimpleTests ()
        {
            Assert.AreEqual(3, Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, Kata.FindShort("turns out random test cases are easier than writing out basic ones"));
        }
    }
}
