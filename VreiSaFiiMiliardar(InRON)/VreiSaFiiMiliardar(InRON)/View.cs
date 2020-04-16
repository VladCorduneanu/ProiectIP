using Interfaces;
using NPresenter;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VreiSaFiiMiliardar_InRON_
{
    public class View : IView
    {
        // The Forms that we are using
        private Form _login;
        private Form _menu;
        private Form _gameView;

        // Presenter reference
        private IPresenter _presenter;


        public View()
        {
            Console.WriteLine("View has been created");
        }
        public bool StartProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Forms creation
            _login = new Login();
            _menu = new Menu();
            _gameView = new GameView();
            Console.WriteLine("Forms have been initialised");

            // Presenter creation
            _presenter = new Presenter((IView)this);

            // Running the app
            Console.WriteLine("Running application");
            Application.Run(_login);

            return true;
        }
    }
}
