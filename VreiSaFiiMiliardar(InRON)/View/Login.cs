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
        IView _viewer;
        public Login(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

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

            bool result =_viewer.Login(username,password);
            if (!result)
            {
                MessageBox.Show("Username inexistent sau parola gresita");
            }
        
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }  


        private void buttonSingUpLogIn_Click(object sender, EventArgs e)
        {
            _viewer.GoToSignUp();
        }
    }
}
