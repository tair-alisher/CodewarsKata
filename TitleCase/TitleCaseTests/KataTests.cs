using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TitleCase;

namespace TitleCaseTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void TitleCase_WhenInputValuesAreEmpty ()
        {
            Assert.AreEqual("", Kata.TitleCase(""));
        }

        [TestMethod]
        public void TitleCase_WhenMinorWordsAreEmpty ()
        {
            Assert.AreEqual("The Quick Brown Fox", Kata.TitleCase("the quick brown fox"));
        }

        [TestMethod]
        public void TitleCase_Tests ()
        {
            Assert.AreEqual("A Clash of Kings", Kata.TitleCase("a clash of KINGS", "a an the of"));
            Assert.AreEqual("The Wind in the Willows", Kata.TitleCase("THE WIND IN THE WILLOWS", "The In"));
        }
    }
}
