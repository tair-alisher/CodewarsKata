using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfDigits;

namespace SumOfDigitsTests
{
    [TestClass]
    public class NumberTests
    {
        [TestMethod]
        public void DigitalRoot_Test ()
        {
            Number num = new Number();
            Assert.AreEqual(7, num.DigitalRoot(16));
            num = null;
        }
    }
}
