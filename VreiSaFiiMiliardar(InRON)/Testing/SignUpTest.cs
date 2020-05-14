using System;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NModelController;

namespace Testing{
    [TestClass]
    public class SignUpTest
    {
        private IModelController _model;


        [TestInitialize]
        public void Init()
        {
            _model = new ModelController();
        }

        [TestMethod]
        public void TestExistingSignUpAlex()
        {
            Assert.AreEqual(false, _model.LoginModule().AddUser("alex", "alex"));
        }

        [TestMethod]
        public void TestExistingSignUpVlad()
        {
            Assert.AreEqual(false, _model.LoginModule().AddUser("vlad", "vlad"));
        }

        [TestMethod]
        public void TestExistingUserAnotherPass()
        {
            Assert.AreEqual(false, _model.LoginModule().AddUser("vlad", "ceva"));
        }

        [TestMethod]
        public void TestSignUpNewUserTest()
        {
            Assert.AreEqual(true, _model.LoginModule().AddUser("test", "test"));
            Assert.AreEqual(true, _model.UserDAO().DeleteUser(new UserModel(0,"test",null,null)));
        }

        [TestMethod]
        public void TestSignUpNewUserGoodTest()
        {
            Assert.AreEqual(true, _model.LoginModule().AddUser("goodTest", "test"));
            Assert.AreEqual(true, _model.UserDAO().DeleteUser(new UserModel(0, "goodTest", null, null)));
        }
    }
}
