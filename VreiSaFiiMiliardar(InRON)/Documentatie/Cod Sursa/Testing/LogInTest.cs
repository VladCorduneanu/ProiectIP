using System;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NModelController;
using NPresenter;

namespace Testing
{
    [TestClass]
    public class LogInTest
    {
        private IModelController _model;


        [TestInitialize]
        public void Init()
        {
            _model = new ModelController();
        }

        [TestMethod]
        public void TestLogInAlex()
        {
            Assert.AreNotEqual(null, _model.LoginModule().Login("alex", "alex"));

        }

        [TestMethod]
        public void TestLogInVlad()
        {
            Assert.AreNotEqual(null, _model.LoginModule().Login("vlad", "vlad"));
        }

        [TestMethod]
        public void WrongUserVladislav()
        {
            Assert.AreEqual(null, _model.LoginModule().Login("Vladislav", "vladislav"));
        }

        [TestMethod]
        public void WrongPasswordAlex()
        {
            Assert.AreEqual(null, _model.LoginModule().Login("alex", "vlad"));
        }

        [TestMethod]
        public void WrongPasswordVlad()
        {
            Assert.AreEqual(null, _model.LoginModule().Login("vlad", "alex"));
        }
    }
}
