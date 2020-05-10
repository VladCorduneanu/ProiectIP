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
    public partial class Settings : Form
    {
        IView _viewer;
        public Settings(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void buttonResetScore_Click(object sender, EventArgs e)
        {
            _viewer.ResetScore();
            MessageBox.Show("Score Reseted");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxSchimbaParola.Text.Equals(""))
            {
                MessageBox.Show("Password can't be blank");
            }
            else
            {
                MessageBox.Show("Password changed");
                _viewer.ChangePassword(textBoxSchimbaParola.Text);
            }
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            _viewer.DeleteAccount();
            MessageBox.Show("Account Deleted");
            return;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _viewer.GoToMenu();
        }
    }
}
