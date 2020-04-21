using Interfaces;
using NModelController;
using NPresenter;
using NView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VreiSaFiiMiliardar_InRON_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Application STARTED");

            IModelController model = new ModelController();
            IView viewer = new NView.View();
            IPresenter presenter = new Presenter(viewer,model);

            viewer.SetPresenter(presenter);
            viewer.StartApplication();

        }
    }
}
