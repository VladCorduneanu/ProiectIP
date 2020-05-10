using Interfaces;
//using NPresenter;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace NView
{
    public class View : IView
    {
        // The Forms that we are using
        private Form _login;
        private Form _signup;
        private Form _menu;
        private Form _gameView;
        private Form _gameEnd;
        private Form _evolution;
        private Form _settings;
        private Form _ranking;

        private bool _gameWon;

        // Presenter reference
        private IPresenter _presenter;

        public View()
        {
            Console.WriteLine("View has been created");
            Init();
        }

        public bool Init()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Forms creation

            _login = new Login(this);
            _menu = new Menu(this);
            _gameView = new GameView(this);
            _gameEnd = new GameEnd(this);
            _signup = new SignUp(this);
            _settings = new Settings(this);
            _ranking = new Ranking(this);
            Console.WriteLine("View::StartProgram() : Forms have been initialised");

            // Running the app
            Console.WriteLine("View::StartProgram() : Running application");

            return true;
        }

        public void GoToMenu()
        {
            _login.Hide();
            _signup.Hide();
            _gameEnd.Hide();
            _settings.Hide();
            _ranking.Hide();
            _menu.Show();
        }

        public void GoToSignUp()
        {
            _login.Hide();
            _signup.Show();
        }
        public void GoToLogIn()
        {
            _signup.Hide();
            _login.Show();
        }

        public void GoToGame()
        {
            _menu.Hide();
            _gameView = new GameView(this);
            _gameView.Show();
        }

        public void GoToGameEnd()
        {
            _gameView.Hide();
            _gameEnd = new GameEnd(this);
            _gameEnd.Show();
        }
        public void GotoSettings()
        {
            _menu.Hide();
            _settings.Show();
        }
        public void GotoRanking()
        {
            _menu.Hide();
            _ranking.Show();
        }
        public bool Login(string username, string password)
        {
            bool result = _presenter.Login(username, password);
            if (result)
            {
                GoToMenu();
            }
            return result;
        }


        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
        }

        public bool StartApplication()
        {
            Application.Run(_login);

            return true;
        }

        public bool SignUp(string username, string password)
        {
            bool result = _presenter.SignUp(username, password);
            if (result)
            {
                GoToMenu();
            }
            return result;
        }

        public void StartGame()
        {
            _presenter.StartGame();
        }

        public QuestionModel GetQuestion()
        {
            return _presenter.GetQuestion();
        }

        bool IView.GetGameWon()
        {
            return _gameWon;
        }
        void IView.SetGameWon(bool value)
        {
            _gameWon = value;
        }

        public void DeleteAccount()
        {
            _presenter.DeleteAccount();
            throw new NotImplementedException();
        }

        public void ChangePassword(string password)
        {
            _presenter.ChangePassword(password);
            throw new NotImplementedException();
        }

        public void ResetScore()
        {
            _presenter.ResetScore();
            throw new NotImplementedException();
        }
    }
}
