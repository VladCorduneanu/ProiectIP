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
        IView _viewer;
      
        public SignUp(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonSignUpBack_Click(object sender, EventArgs e)
        {
            _viewer.GoToLogIn();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxSignUpUsername.Text;
            string password = textBoxSignUpPassword.Text;
            string confirm = textBoxSignUpConfirm.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Username can't be blank");
                return;
            }
            if (password.Equals(""))
            {
                MessageBox.Show("Password can't be blank");
                return;
            }

            if (!password.Equals(confirm))
            {
                MessageBox.Show("Password doesn`t match");
                return;
            }

            bool result = _viewer.SignUp(username, password);
            if (!result)
            {
                MessageBox.Show("Exista deja un utilizator cu aces nume");
            }
            else {
                textBoxSignUpUsername.Text = "";
                textBoxSignUpPassword.Text = "";
                textBoxSignUpConfirm.Text = "";
            }
        }
    }
}
