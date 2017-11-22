using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StopSpinningMyWords;

namespace StopSpinningMyWordsTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void SpinWords_Tests ()
        {
            Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
            Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
            Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
            Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
            Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
        }
    }
}
