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
    public partial class Ranking : Form
    {
        IView _viewer;
        public Ranking(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
        }
        private void Ranking_Load(object sender, EventArgs e)
        {
            labelRanking.Text = _viewer.GetRankingTable();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _viewer.GoToMenu();
        }

        private void labelRanking_Click(object sender, EventArgs e)
        {

        }
    }
}
