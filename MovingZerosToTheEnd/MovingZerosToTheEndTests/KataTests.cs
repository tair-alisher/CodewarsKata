using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovingZerosToTheEnd;

namespace MovingZerosToTheEndTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void MoveZeroes_Tests ()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}
