using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAcces;
using Interfaces;
using NGameModel;
using NLogin;

namespace NModelController
{
    public class ModelController:IModelController
    {
        //private IPresenter _presenter;
        private ILoginModule _proxy;
        private IQuestionDAO _questionDAO;
        private IUserDAO _userDAO;
        private IGameModel _gameModel;

        public ILoginModule LoginModule()
        {
            return _proxy;
        }
        public IQuestionDAO QuestionDAO()
        {
            return _questionDAO;
        }
        public IUserDAO UserDAO()
        {
            return _userDAO;
        }
        public IGameModel GameModel()
        {
            return _gameModel;
        }

        public ModelController(/*IPresenter presenter*/)
        {
            //_presenter = presenter;
            _proxy = new LoginModule(this);
            _questionDAO = new QuestionDAOService(this,Environment.CurrentDirectory + "/questions.db");
            _userDAO = new UserDAOService(this,Environment.CurrentDirectory + "/users.db");
            _gameModel = new GameModel(this);
        }
    }
}
