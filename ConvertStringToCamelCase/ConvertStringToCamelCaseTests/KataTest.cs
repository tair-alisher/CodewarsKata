using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertStringToCamelCase;

namespace ConvertStringToCamelCaseTests
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void ToCamelCase_WhenInputStringSeparateByDash ()
        {
            Assert.AreEqual("TheStealthWarrior", Kata.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }

        [TestMethod]
        public void ToCamleCase_WhenInputStringSeparatedByUnderscore ()
        {
            Assert.AreEqual("theStealthWarrior", Kata.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        }
    }
}
