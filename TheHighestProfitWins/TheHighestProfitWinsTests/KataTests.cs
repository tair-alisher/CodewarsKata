using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheHighestProfitWins;

namespace TheHighestProfitWinsTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void MinMax_TestWithNegativeNumbers ()
        {
            CollectionAssert.AreEqual(new int[] { -1, 20 }, Kata.MinMax(new int[] { 1, 2, 5, -1, 12, 20 }));
            CollectionAssert.AreEqual(new int[] { -3, 5 }, Kata.MinMax(new int[] { 1, 2, -3, 4, 5 }));
        }

        [TestMethod]
        public void MinMax_TestWithoutNegativeNumbers ()
        {
            CollectionAssert.AreEqual(new int[] { 1, 5 }, Kata.MinMax(new int[] { 1, 2, 3, 4, 5 }));
        }
    }
}
