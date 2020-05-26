/**************************************************************************
 *                                                                        *
 *  File:        Ranking.cs                                               *
 *  Atuhors:     Baciu H. Alexandru, Corduneanu Vlad, Haralamb Marian     *
 *  Contributions: The authors' contribution depends on the               *
 *  implementation of tasks                                               *
 *                                                                        *
 *                                                                        *
 *  Description: Contains a form created according to the requirment of   *
 *  project                                                               *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
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
        // reference to view
        IView _viewer;

        // constructor with parameters to set viewer and initialize object from interface
        public Ranking(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
        }

        /// <summary>
        /// First initialize when form is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ranking_Load(object sender, EventArgs e)
        {
            labelRanking.Text = _viewer.GetRankingTable();
        }

        /// <summary>
        /// Event for Back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            _viewer.GoToMenu();
        }

        /// <summary>
        /// Event for X button of window
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
