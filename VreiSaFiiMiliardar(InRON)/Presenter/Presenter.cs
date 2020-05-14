using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPresenter
{
    public class Presenter : IPresenter
    {
        private IView _view;
        private IModelController _model;
        private List<QuestionModel> _level1Questions;
        private List<QuestionModel> _level2Questions;
        private List<QuestionModel> _level3Questions;
        private int _currentQuestion;
        private Random _random;
        private UserModel _user;

        public Presenter(IView view, IModelController model)
        {
            Init(view,model);
        }

        public void ChangePassword(string password)
        {
            _model.LoginModule().UpdateUser(_user, password);
        }

        public void DeleteAccount()
        {
            _model.UserDAO().DeleteUser(_user);
        }

        public QuestionModel GetQuestion()
        {
            int number = 0;
            QuestionModel question;
            if (_currentQuestion < 5)
            {
                number = _random.Next(_level1Questions.Count);
                question = _level1Questions[number];
                _level1Questions.RemoveAt(number);
            }
            else if(_currentQuestion < 10)
            {
                number = _random.Next(_level2Questions.Count);
                question = _level2Questions[number];
                _level2Questions.RemoveAt(number);
            }
            else if(_currentQuestion < 15)
            {
                number = _random.Next(_level3Questions.Count);
                question = _level3Questions[number];
                _level3Questions.RemoveAt(number);
            }
            else
            {
                question = null;
                // s-au term intrebarile
            }
            _currentQuestion++;

            return question;
        }

        public string GetRankingTable()
        {
            StringBuilder sb = new StringBuilder("");
            List<UserModel> usersRanking = _model.UserDAO().GetUserRankings();
            for (int i = 0; i < usersRanking.Count; i++)
            {
                if (usersRanking[i].Evolution == "15")
                {
                    sb.Append(usersRanking[i].Username + " a castigat premiul cel mare, ajungand la intrebarea " + usersRanking[i].Evolution + "\n");
                }
                else
                {
                    sb.Append(usersRanking[i].Username + " nu a castigat inca, oprindu-se la intrebarea numarul " + usersRanking[i].Evolution + "\n");
                }

                if (i == 9)
                {
                    break;
                }
            }

            return sb.ToString();
        }

        public string GetUsername()
        {
            return _user.Username;
        }

        public void Init(IView view, IModelController model)
        {
            _view = view;
            _model = model;
            _currentQuestion = 0;
            _random = new Random();
        }

        public bool Login(string username, string password)
        {
           _user = _model.LoginModule().Login(username, password);

            if(_user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ResetScore()
        {
            _model.UserDAO().UpdateEvolution(_user.Username, "0");
        }

        public bool SignUp(string username, string password)
        {
            return _model.LoginModule().AddUser(username, password);
        }

        public void StartGame()
        {
            _level1Questions = _model.QuestionDAO().GetQuestions(1);
            _level2Questions = _model.QuestionDAO().GetQuestions(2);
            _level3Questions = _model.QuestionDAO().GetQuestions(3);

            _currentQuestion = 0;
        }

        public bool UpdateUserEvolution(string evolution)
        {
            string currentEvolution;
            currentEvolution = _model.UserDAO().GetEvolution(_user.Username);
            if(currentEvolution == "")
            {
                return false;
            }
            if(Convert.ToInt32(currentEvolution) < Convert.ToInt32(evolution))
            {
                _model.UserDAO().UpdateEvolution(_user.Username, evolution);
            }          
            return true;

            
        }
    }
}
