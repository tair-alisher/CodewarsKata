using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordA10n;

namespace WordA10nTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Abbreviate_TestInternationalization ()
        {
            Assert.AreEqual("i18n", Kata.Abbreviate("internationalization"));
        }

        [TestMethod]
        public void Abbreviate_TestShortSentance()
        {
            Assert.AreEqual("my. dog, isn't f5g v2y w2l.", Kata.Abbreviate("my. dog, isn't feeling very well."));
        }
    }
}
