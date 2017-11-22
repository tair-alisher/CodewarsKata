using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhoLikesIt;

namespace WhoLikesItTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Likes_OneName ()
        {
            Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
        }

        [TestMethod]
        public void Likes_MoreThanOneName ()
        {
            Assert.AreEqual("Peter likes this", Kata.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
