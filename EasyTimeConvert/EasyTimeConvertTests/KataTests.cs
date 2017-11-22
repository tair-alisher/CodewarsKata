using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyTimeConvert;

namespace EasyTimeConvertTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void TimeConvert_WhenInputValueIs0 ()
        {
            Assert.AreEqual("00:00", Kata.TimeConvert(0));
        }

        [TestMethod]
        public void TimeConvert_WhenInputValueIsLessThan0 ()
        {
            Assert.AreEqual("00:00", Kata.TimeConvert(-6));
        }

        [TestMethod]
        public void TimeConvert_WhenInputValueIsMoreThan0 ()
        {
            Assert.AreEqual("00:08", Kata.TimeConvert(8));
            Assert.AreEqual("00:32", Kata.TimeConvert(32));
            Assert.AreEqual("01:15", Kata.TimeConvert(75));
            Assert.AreEqual("01:03", Kata.TimeConvert(63));
            Assert.AreEqual("02:14", Kata.TimeConvert(134));
            Assert.AreEqual("03:00", Kata.TimeConvert(180));
            Assert.AreEqual("16:10", Kata.TimeConvert(970));
            Assert.AreEqual("9429:17", Kata.TimeConvert(565757));
        }
    }
}
