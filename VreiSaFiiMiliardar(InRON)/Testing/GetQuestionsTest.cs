using System;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NModelController;

namespace Testing
{
    [TestClass]
    public class GetQuestionsTest
    {
        private IModelController _model;


        [TestInitialize]
        public void Init()
        {
            _model = new ModelController();
        }

        [TestMethod]
        public void TestGetLevel1Questions()
        {
            Assert.AreEqual(25, _model.QuestionDAO().GetQuestions(1).Count);
        }
        [TestMethod]
        public void TestGetLevel2Questions()
        {
            Assert.AreEqual(25, _model.QuestionDAO().GetQuestions(2).Count);
        }

        [TestMethod]
        public void TestGetLevel3Questions()
        {
            Assert.AreEqual(25, _model.QuestionDAO().GetQuestions(3).Count);
        }

        [TestMethod]
        public void TestGetWrongLevelQuestions()
        {
            Assert.AreEqual(0, _model.QuestionDAO().GetQuestions(0).Count);
        }

        [TestMethod]
        public void TestGetAnotherLevelQuestions()
        {
            Assert.AreEqual(0, _model.QuestionDAO().GetQuestions(1000).Count);
        }

    }
}
