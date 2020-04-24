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
        private string _correctAnswer;
        private int _secondsRemaining;
        public GameView(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
            labelHelp.Text = "Salut. Stii regulile,\n sunt simple: 15 intrebari," +
                             "\n30 de secunde intrebarea.\n Nu uita, ai parte si de ajutor\n" +
                             "Apasa start pentru a incepe.";
            DeactivateStartGame();
        }

        public void DeactivateStartGame()
        {
            labelAnswerA.Visible = false;
            labelAnswerB.Visible = false;
            labelAnswerC.Visible = false;
            labelAnswerD.Visible = false;
            labelQuestion.Visible = false;
            labelFiftyFifty.Visible = false;
            labelCallFriend.Visible = false;
            labelPublic.Visible = false;
            labelTimer.Visible = false;
        }

        public void ActivateStartGame()
        {
            labelTimer.Visible = true;
            labelHelp.Visible = false;
            buttonStart.Visible = false;
            labelAnswerA.Visible = true;
            labelAnswerB.Visible = true;
            labelAnswerC.Visible = true;
            labelAnswerD.Visible = true;
            labelQuestion.Visible = true;
            labelFiftyFifty.Visible = true;
            labelCallFriend.Visible = true;
            labelPublic.Visible = true;
            labelFiftyFifty.Text = "";
            labelCallFriend.Text = "";
            labelPublic.Text = "";

            _viewer.StartGame();
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

        private void buttonStart_Click(object sender, EventArgs e)
        {


            BackgroundImage = global::View.Properties.Resources.in_game_image;
            ActivateStartGame();

            QuestionModel question = _viewer.GetQuestion();
            if(question != null)
            {
                labelQuestion.Text = question.Question;
                labelAnswerA.Text = question.AnswerA;
                labelAnswerB.Text = question.AnswerB;
                labelAnswerC.Text = question.AnswerC;
                labelAnswerD.Text = question.AnswerD;
                _correctAnswer = question.CorrectAnswer;

                _secondsRemaining = 30;
                timerQuestion.Interval = 1000;
                timerQuestion.Enabled = true;

                labelTimer.Text = "30";
                labelTimer.ForeColor = Color.Green;
            
            }
            else
            {
                 // eroare
            }


        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            _secondsRemaining--;
            if(_secondsRemaining > 0)
            {
                labelTimer.Text = _secondsRemaining.ToString();
                if(_secondsRemaining < 6)
                {
                    labelTimer.ForeColor = Color.Red;
                }
            }
            else
            {
                timerQuestion.Enabled = false;
                // TODO
            }
        }
    }
}
