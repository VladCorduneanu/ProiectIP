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
    public partial class GameView : System.Windows.Forms.Form
    {
        IView _viewer;
        public GameView(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
            labelHelp.Text = "Salut. Stii regulile,\n sunt simple: 15 intrebari," +
                             "\n30 de secunde intrebarea.\n Nu uita, ai parte si de ajutor\n" +
                             "Apasa start pentru a incepe.";
        }

        private void GameView_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelMoney2_Click(object sender, EventArgs e)
        {

        }
    }
}
