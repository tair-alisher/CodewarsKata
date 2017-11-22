using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Base64Encoding;

namespace Base64EncodingTests
{
    [TestClass]
    public class Base64EncodingTests
    {
        [TestMethod]
        public void ToBase64_EncodeTests ()
        {
            Assert.AreEqual("dGhpcyBpcyBhIHN0cmluZyEh", Base64Utils.ToBase64("this is a string!!"));
            Assert.AreEqual("ZWU=", Base64Utils.ToBase64("ee"));
            Assert.AreEqual("ZQ==", Base64Utils.ToBase64("e"));
            Assert.AreEqual("", Base64Utils.ToBase64(""));
        }

        [TestMethod]
        public void FromBase64_DecodeTests ()
        {
            Assert.AreEqual("this is a string!!", Base64Utils.FromBase64("dGhpcyBpcyBhIHN0cmluZyEh"));
            Assert.AreEqual("ee", Base64Utils.FromBase64("ZWU="));
            Assert.AreEqual("e", Base64Utils.FromBase64("ZQ=="));
            Assert.AreEqual("", Base64Utils.FromBase64(""));
        }
    }
}
