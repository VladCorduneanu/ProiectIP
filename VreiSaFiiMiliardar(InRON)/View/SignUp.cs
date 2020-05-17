/**************************************************************************
 *                                                                        *
 *  File:        SignUp.cs                                                *
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

namespace View
{
    public partial class SignUp : Form
    {
        // reference to view
        IView _viewer;

        // constructor with parameters to set viewer and initialize object from interface
        public SignUp(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
        }

        /// <summary>
        /// First initialize when form is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUp_Load(object sender, EventArgs e)
        {
            

        }

        /// <summary>
        /// Event for back button
        /// </summary>
        /// <param name="e"></param>
        private void buttonSignUpBack_Click(object sender, EventArgs e)
        {
            _viewer.GoToLogIn();
        }

        /// <summary>
        /// Event for Sign up button
        /// </summary>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            // getting informations from interfaces
            string username = textBoxSignUpUsername.Text;
            string password = textBoxSignUpPassword.Text;
            string confirm = textBoxSignUpConfirm.Text;

            // check if username match a good pattern
            if (username.Equals(""))
            {
                MessageBox.Show("Username can't be blank");
                return;
            }

            // check if password match a good pattern
            if (password.Equals(""))
            {
                MessageBox.Show("Password can't be blank");
                return;
            }

            // chack if password are the same
            if (!password.Equals(confirm))
            {
                MessageBox.Show("Password doesn`t match");
                return;
            }

            // start to sign up the user
            bool result = _viewer.SignUp(username, password);

            // checking the result of sign up
            if (!result)
            {
                MessageBox.Show("Exista deja un utilizator cu aces nume");
            }
            else
            {
                //reset textboxes
                textBoxSignUpUsername.Text = "";
                textBoxSignUpPassword.Text = "";
                textBoxSignUpConfirm.Text = "";
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
    }
}
