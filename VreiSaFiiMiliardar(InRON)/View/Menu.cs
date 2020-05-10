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
    public partial class Menu : System.Windows.Forms.Form
    {
        IView _viewer;
        public Menu(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            labelUsername.Text = "Salut, " + _viewer.GetUsername();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            _viewer.GoToGame();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();         
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            _viewer.GotoSettings();
        }

        private void buttonRanking_Click(object sender, EventArgs e)
        {
            _viewer.GotoRanking();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "VreiSaFiiMilionar.chm");
        }

    }
}
