using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddingBigNumbers;
using System.Numerics;

namespace AddingBigNumbersTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Add_TestWhenInputValuesAreSmall ()
        {
            Assert.AreEqual("110", Kata.Add("91", "19"));
        }

        [TestMethod]
        public void Add_TestWhenInputValuesAreBig ()
        {
            string a = "823094582094385190384102934810293481029348123094818923749817";
            string b = "234758927345982475298347523984572983472398457293847594193837";
            string expected = "1057853509440367665682450458794866464501746580388666517943654";
            Assert.AreEqual(expected, Kata.Add(a,b));
        }

        [TestMethod]
        public void Add_Test ()
        {
            Assert.AreEqual("101060", Kata.Add("74587", "26473"));
        }
    }
}
