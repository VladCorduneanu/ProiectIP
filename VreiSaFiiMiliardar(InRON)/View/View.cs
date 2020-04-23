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
        private Form _evolution;
        private Form _gameEnded;
        private Form _settings;

        // Presenter reference
        private IPresenter _presenter;

        public View()
        {
            Console.WriteLine("View has been created");
            Init();
        }


        public void GoToGame()
        {
            _login.Hide();
            _signup.Hide();
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

        public bool Init()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Forms creation

            _login = new Login(this);
            _menu = new Menu(this);
            _gameView = new GameView(this);
            _signup = new SignUp(this);
            Console.WriteLine("View::StartProgram() : Forms have been initialised");

            // Running the app
            Console.WriteLine("View::StartProgram() : Running application");
            
            return true;
        }

        public bool Login(string username, string password)
        {
            bool result = _presenter.Login(username, password);
            if (result)
            {
                this.GoToGame();
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
                this.GoToGame();
            }
            return result;
        }
    }
}
