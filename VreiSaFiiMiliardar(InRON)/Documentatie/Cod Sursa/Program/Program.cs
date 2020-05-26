/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Atuhors:     Baciu H. Alexandru, Corduneanu Vlad, Haralamb Marian     *
 *  Contributions: The authors' contribution depends on the               *
 *  implementation of tasks                                               *
 *                                                                        *
 *                                                                        *
 *  Description: Contains entry point of application                      *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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
            //creating the layers for MVP arhitecture
            IModelController model = new ModelController();
            IView viewer = new NView.View();
            IPresenter presenter = new Presenter(viewer,model);

            //seting the presenter for the view layer
            viewer.SetPresenter(presenter);

            //starting application
            viewer.StartApplication();

        }
    }
}
