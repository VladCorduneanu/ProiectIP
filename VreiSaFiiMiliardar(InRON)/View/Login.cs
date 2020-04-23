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
            groupBoxSingUp.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _viewer.Login(textBoxUsername.Text, textBoxPassword.Text);
        
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

     

        private void groupBoxLogIn_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSignUpBack_Click(object sender, EventArgs e)
        {
            groupBoxLogIn.Visible = true;
            groupBoxSingUp.Visible = false;
        }

        private void groupBoxSingUp_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSingUpLogIn_Click(object sender, EventArgs e)
        {
            groupBoxSingUp.Visible = true;
           // groupBoxLogIn.Visible = false;
            
           
        }
    }
}
