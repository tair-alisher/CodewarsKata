using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversedSequence;

namespace ReversedSequenceTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void ReverseSeq_Test ()
        {
            CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, Kata.ReverseSeq(5));
        }
    }
}
