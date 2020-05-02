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

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
