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
    public partial class GameEnd : Form
    {
        IView _viewer;
        public GameEnd(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
        }

        public void SetGameEnd(string advice, string text)
        {
            labelVirgil.Text = advice;
            labelFinal.Text = text;
        }

        private void GameEnd_Load(object sender, EventArgs e)
        {
            
            bool gameWon = _viewer.GetGameWon();

            if (gameWon == true)
            {
                SetGameEnd("Felicitari, ai jucat foarte bine!", "Ai castigat premiul cel mare");

            }
            else
            {
                SetGameEnd("Ai jucat foarte bine. Te mai asteptam.", "Din pacate pleci acasa cu mana goala");
            }
        }


        private void labelFinal_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            _viewer.GoToMenu();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
