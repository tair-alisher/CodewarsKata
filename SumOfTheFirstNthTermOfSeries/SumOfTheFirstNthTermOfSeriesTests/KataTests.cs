using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfTheFirstNthTermOfSeries;

namespace SumOfTheFirstNthTermOfSeriesTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void SeriesSum_WhenInputValueIs0 ()
        {
            Assert.AreEqual("0.00", Kata.SeriesSum(0));
        }

        [TestMethod]
        public void SeriesSum_WhenInputValueIsPositive ()
        {
            Assert.AreEqual("1.77", Kata.SeriesSum(9));
            Assert.AreEqual("1.57", Kata.SeriesSum(5));
        }
    }
}
