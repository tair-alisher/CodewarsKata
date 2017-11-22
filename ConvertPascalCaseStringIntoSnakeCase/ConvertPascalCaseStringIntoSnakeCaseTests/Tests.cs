using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertPascalCaseStringIntoSnakeCase;

namespace ConvertPascalCaseStringIntoSnakeCaseTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ToUnderscore_WithoutNumbers ()
        {
            Assert.AreEqual("test_controller", Kata.ToUnderscore("TestController"));
            Assert.AreEqual("this_is_beautiful_day", Kata.ToUnderscore("ThisIsBeautifulDay"));
            Assert.AreEqual("arbitrarily_sending_different_types_to_functions_makes_katas_cool", Kata.ToUnderscore("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool"));
        }

        [TestMethod]
        public void ToUnderscore_WithNumbers ()
        {
            Assert.AreEqual("am7_days", Kata.ToUnderscore("Am7Days"));
            Assert.AreEqual("my3_code_is4_times_better", Kata.ToUnderscore("My3CodeIs4TimesBetter"));
        }

        [TestMethod]
        public void ToUnderscore_WhenInputValueIsNumber ()
        {
            Assert.AreEqual("1", Kata.ToUnderscore(1), "Numbers should be turned to strings!");
        }
    }
}
