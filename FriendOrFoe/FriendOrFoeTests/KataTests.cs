using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FriendOrFoe;

namespace FriendOrFoeTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void FriendOrFoe_Test ()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
        }
    }
}
