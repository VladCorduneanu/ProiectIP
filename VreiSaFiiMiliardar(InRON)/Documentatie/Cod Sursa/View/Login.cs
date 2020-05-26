/**************************************************************************
 *                                                                        *
 *  File:        Login.cs                                                 *
 *  Atuhors:     Baciu H. Alexandru, Corduneanu Vlad, Haralamb Marian     *
 *  Contributions: The authors' contribution depends on the               *
 *  implementation of tasks                                               *
 *                                                                        *
 *                                                                        *
 *  Description: Contains a form created according to the requirment of   *
 *  project                                                               *
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NView
{
    public partial class Login : System.Windows.Forms.Form
    {
        // reference to view
        IView _viewer;

        // constructor with parameters to set viewer and initialize object from interface
        public Login(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();        
        }

        /// <summary>
        /// First initialize when form is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event for Log In button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // getting information from interface
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // check validity of username
            if (username.Equals(""))
            {
                MessageBox.Show("Username can't be blank");
                return;
            }

            // check validity of password
            if (password.Equals(""))
            {
                MessageBox.Show("Password can't be blank");
                return;
            }

            // starting log in
            bool result =_viewer.Login(username,password);

            // checking log in result
            if (!result)
            {
                MessageBox.Show("Username inexistent sau parola gresita");
            }
        
        }

        /// <summary>
        /// Event for X button of window
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }  

        /// <summary>
        /// Event for Sign Up button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSingUpLogIn_Click(object sender, EventArgs e)
        {
            _viewer.GoToSignUp();
        }
    }
}
