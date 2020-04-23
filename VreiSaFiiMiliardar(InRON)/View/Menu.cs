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

        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();         
        }
    }
}
