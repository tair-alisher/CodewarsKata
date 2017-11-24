using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YourOrderPlease;

namespace YourOrderPleaseTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Order_Tests ()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", Kata.Order("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));
        }

        [TestMethod]
        public void Order_WhenInputStringIsEmpty ()
        {
            Assert.AreEqual("", Kata.Order(""));
        }
    }
}
