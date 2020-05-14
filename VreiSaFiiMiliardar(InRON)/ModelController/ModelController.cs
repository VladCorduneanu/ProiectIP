using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAcces;
using Interfaces;
using NLogin;

namespace NModelController
{
    public class ModelController:IModelController
    {
        //private IPresenter _presenter;
        private ILoginModule _login;
        private IQuestionDAO _questionDAO;
        private IUserDAO _userDAO;

        public ILoginModule LoginModule()
        {
            return _login;
        }
        public IQuestionDAO QuestionDAO()
        {
            return _questionDAO;
        }
        public IUserDAO UserDAO()
        {
            return _userDAO;
        }

        public ModelController(/*IPresenter presenter*/)
        {
            //_presenter = presenter;
            _login = new LoginModule(this);
            _questionDAO = new QuestionDAOService(this,Environment.CurrentDirectory + "/questions.db");
            _userDAO = new UserDAOService(this,Environment.CurrentDirectory + "/users.db");
        }
    }
}
