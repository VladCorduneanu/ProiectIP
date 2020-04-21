using Interfaces;
//using NPresenter;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NView
{
    public class View : IView
    {
        // The Forms that we are using
        private Form _login;
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

        public bool Init()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Forms creation

            _login = new Login();
            _menu = new Menu();
            _gameView = new GameView();
            Console.WriteLine("View::StartProgram() : Forms have been initialised");

            // Running the app
            Console.WriteLine("View::StartProgram() : Running application");
            
            return true;
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
    }
}
