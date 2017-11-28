using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionGiveMeAllMethods;
using System.Linq;

namespace ReflectionGiveMeAllMethodsTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void NullTest ()
        {
            Assert.AreEqual(0, Kata.GetMethodNames(null).Length);
        }

        [TestMethod]
        public void NewObjectTest ()
        {
            var testObject = new object();
            var methodNameArray = Kata.GetMethodNames(testObject);
            Assert.IsTrue(methodNameArray.Contains("ToString"));
        }
    }
}
