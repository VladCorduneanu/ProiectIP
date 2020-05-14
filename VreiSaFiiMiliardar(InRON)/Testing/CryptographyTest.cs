using System;
using System.Security.Cryptography;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class CryptographyTest { 



        [TestMethod]
        public void TestDecryptPasswordAbcd()
        {
            Assert.AreEqual("abcd", Cryptography.Decrypt((Cryptography.Encrypt("abcd","cheie")),"cheie"));
        }

        [TestMethod]
        public void TestDecryptPasswordAlex()
        {
            Assert.AreEqual("alex", Cryptography.Decrypt((Cryptography.Encrypt("alex", "cheie")), "cheie"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(CryptographicException))]
        public void TestDecryptWrongKeySamePasswords()
        {
            Assert.AreNotEqual("alex", Cryptography.Decrypt((Cryptography.Encrypt("alex", "cheie")), "cheie1"));
        }

        [TestMethod]
        public void TestDecryptWrongPasswordsAlex()
        {
            Assert.AreNotEqual("alex1", Cryptography.Decrypt((Cryptography.Encrypt("alex", "cheie")), "cheie"));
        }

        [TestMethod]
        public void TestDecryptWrongPasswordsVlad()
        {
            Assert.AreNotEqual("vlad", Cryptography.Decrypt((Cryptography.Encrypt("vlad1", "cheie")), "cheie"));
        }
    }
}
