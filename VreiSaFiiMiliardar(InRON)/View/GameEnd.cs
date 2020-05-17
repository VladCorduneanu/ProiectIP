/**************************************************************************
 *                                                                        *
 *  File:        GameEnd.cs                                               *
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
    public partial class GameEnd : Form
    {
        // reference to view
        IView _viewer;

        // constructor with parameters to set viewer and initialize object from interface
        public GameEnd(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
        }

        /// <summary>
        /// First initialize when form is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameEnd_Load(object sender, EventArgs e)
        {
            //getting game status
            bool gameWon = _viewer.GetGameWon();

            // checking game status
            if (gameWon == true)
            {
                SetGameEnd("Felicitari, ai jucat foarte bine!", "Ai castigat premiul cel mare");
            }
            else
            {
                SetGameEnd("Ai jucat foarte bine. Te mai asteptam.", "Din pacate pleci acasa cu mana goala");
            }
        }

        /// <summary>
        /// Setter for labels of game end
        /// </summary>
        /// <param name="advice"></param>
        /// <param name="text"></param>
        public void SetGameEnd(string advice, string text)
        {
            labelVirgil.Text = advice;
            labelFinal.Text = text;
        }

        /// <summary>
        /// Event for Menu button
        /// </summary>
        /// <param name="e"></param>
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            _viewer.GoToMenu();
        }

        /// <summary>
        /// Event for X button of windows
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
