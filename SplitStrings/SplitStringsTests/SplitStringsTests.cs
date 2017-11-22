using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitStrings;

namespace SplitStringsTests
{
    [TestClass]
    public class SplitStringsTests
    {
        [TestMethod]
        public void Solution_Tests ()
        {
            CollectionAssert.AreEqual(new string[] { "ab", "c_" }, SplitString.Solution("abc"));
            CollectionAssert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
        }
    }
}
