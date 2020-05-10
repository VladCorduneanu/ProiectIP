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
        private bool _nextQuestion;
        private int _secondsRemaining;
        private bool _fiftyFiftyPressed;
        private bool _callAFriendPressed;
        private bool _publicPressed;
        private int _currentQuestion;
        private List<Label> _labels;
        public GameView(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();
            _labels = new List<Label>();

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
            _publicPressed = false;
            _fiftyFiftyPressed = false;
            _callAFriendPressed = false;
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
            _currentQuestion = 0;

            _labels.Add(labelMoney0);
            _labels.Add(labelMoney1);
            _labels.Add(labelMoney2);
            _labels.Add(labelMoney3);
            _labels.Add(labelMoney4);
            _labels.Add(labelMoney5);
            _labels.Add(labelMoney6);
            _labels.Add(labelMoney7);
            _labels.Add(labelMoney8);
            _labels.Add(labelMoney9);
            _labels.Add(labelMoney10);
            _labels.Add(labelMoney11);
            _labels.Add(labelMoney12);
            _labels.Add(labelMoney13);
            _labels.Add(labelMoney14);
            

            _viewer.StartGame();
        }

        private void GameView_Load(object sender, EventArgs e)
        {

            //InitializeComponent();
            labelHelp.Text = "Salut. Stii regulile,\n sunt simple: 15 intrebari," +
                             "\n30 de secunde intrebarea.\n Nu uita, ai parte si de ajutor\n" +
                             "Apasa start pentru a incepe.";
            DeactivateStartGame();
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
            NewQuestion();

        }

        private void NewQuestion()
        {
          

            QuestionModel question = _viewer.GetQuestion();
            if (question != null)
            {
                if (_currentQuestion > 0)
                {
                    _labels[_currentQuestion].BackColor = Color.Orange;
                    _labels[_currentQuestion].Text = "->" + _labels[_currentQuestion].Text;
                    _labels[_currentQuestion - 1].BackColor = Color.Transparent;
                    _labels[_currentQuestion - 1].Text = _labels[_currentQuestion - 1].Text.Substring(2);
                }
                else
                {
                    _labels[_currentQuestion].BackColor = Color.Orange;
                    _labels[_currentQuestion].Text = "->" + _labels[_currentQuestion].Text;
                }
                _currentQuestion++;

                labelQuestion.Text = question.Question;
                labelAnswerA.Text = question.AnswerA;
                labelAnswerB.Text = question.AnswerB;
                labelAnswerC.Text = question.AnswerC;
                labelAnswerD.Text = question.AnswerD;
                labelAnswerA.ForeColor = Color.White;
                labelAnswerB.ForeColor = Color.White;
                labelAnswerC.ForeColor = Color.White;
                labelAnswerD.ForeColor = Color.White;
                labelAnswerA.Visible = true;
                labelAnswerB.Visible = true;
                labelAnswerC.Visible = true;
                labelAnswerD.Visible = true;
                _correctAnswer = question.CorrectAnswer;

                _secondsRemaining = 30;
                timerQuestion.Interval = 1000;
                timerQuestion.Enabled = true;

                labelTimer.Text = "30";
                labelTimer.ForeColor = Color.Green;

            }
            else
            {
                timerQuestion.Enabled = false;

                _viewer.SetGameWon(true);
                _viewer.UpdateUserEvolution((_currentQuestion).ToString());
                _viewer.GoToGameEnd();
                // terminare joc
            }
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            _secondsRemaining--;
            if (_secondsRemaining > 0)
            {
                labelTimer.Text = _secondsRemaining.ToString();
                if (_secondsRemaining < 6)
                {
                    labelTimer.ForeColor = Color.Red;
                }
            }
            else
            {
                timerQuestion.Enabled = false;
                _viewer.UpdateUserEvolution((_currentQuestion-1).ToString());
                _viewer.SetGameWon(false);
                _viewer.GoToGameEnd();
            }
        }

        private void QuestionResponse()
        {
            switch (_correctAnswer)
            {
                case "A":
                    labelAnswerA.ForeColor = Color.Green;
                    break;
                case "B":
                    labelAnswerB.ForeColor = Color.Green;
                    break;
                case "C":
                    labelAnswerC.ForeColor = Color.Green;
                    break;
                case "D":
                    labelAnswerD.ForeColor = Color.Green;
                    break;

            }
            timerQuestion.Enabled = false;
            timerResponse.Interval = 3000;
            timerResponse.Enabled = true;
        }

        private void labelAnswerA_Click(object sender, EventArgs e)
        {
            if (_correctAnswer == "A")
            {
                _nextQuestion = true;

            }
            else
            {
                labelAnswerA.ForeColor = Color.Red;
                _nextQuestion = false;
            }

            QuestionResponse();

        }
        private void labelAnswerB_Click(object sender, EventArgs e)
        {
            if (_correctAnswer == "B")
            {
                _nextQuestion = true;

            }
            else
            {
                labelAnswerB.ForeColor = Color.Red;
                _nextQuestion = false;
            }

            QuestionResponse();
        }

        private void labelAnswerC_Click(object sender, EventArgs e)
        {
            if (_correctAnswer == "C")
            {
                _nextQuestion = true;

            }
            else
            {
                labelAnswerC.ForeColor = Color.Red;
                _nextQuestion = false;
            }

            QuestionResponse();
        }


        private void labelAnswerD_Click(object sender, EventArgs e)
        {
            if (_correctAnswer == "D")
            {
                _nextQuestion = true;

            }
            else
            {
                labelAnswerD.ForeColor = Color.Red;
                _nextQuestion = false;
            }

            QuestionResponse();
        }


        private void timerResponse_Tick(object sender, EventArgs e)
        {
            if (_nextQuestion == true)
            {
                NewQuestion();
            }
            else
            {
                _viewer.SetGameWon(false);
                _viewer.UpdateUserEvolution((_currentQuestion - 1).ToString());
                _viewer.GoToGameEnd();
            }

            timerResponse.Enabled = false;
        }

        private void labelFiftyFifty_Click(object sender, EventArgs e)
        {
            if (_fiftyFiftyPressed)
                return;
            _fiftyFiftyPressed = true;
            int number = Convert.ToInt32(_correctAnswer[0] - 'A');
            int var;
            Random rand = new Random();
            int i = 0;
            while (i < 2)
            {
                var = rand.Next(4);
                if (var == number)
                    continue;
                switch (var)
                {
                    case 0:
                        if (labelAnswerA.Visible == false)
                            continue;
                        labelAnswerA.Visible = false;
                        break;
                    case 1:
                        if (labelAnswerB.Visible == false)
                            continue;
                        labelAnswerB.Visible = false;
                        break;
                    case 2:
                        if (labelAnswerC.Visible == false)
                            continue;
                        labelAnswerC.Visible = false;
                        break;
                    case 3:
                        if (labelAnswerD.Visible == false)
                            continue;
                        labelAnswerD.Visible = false;
                        break;

                }
                i++;

            }
            labelFiftyFifty.Text = "X";
            labelFiftyFifty.ForeColor = Color.Red;
            labelFiftyFifty.Font = new Font("Consolas", 80.0f, FontStyle.Bold);
            labelFiftyFifty.Location = new Point(30,48);
        }

        private void labelPublic_Click(object sender, EventArgs e)
        {
            if (_publicPressed == true)
                return;
            _publicPressed = true;

            Random random = new Random();

            List<int> answers = new List<int>();
            if(labelAnswerA.Visible == true)
            {
                if ("A" == _correctAnswer)
                    answers.Add(random.Next(7,12));
                else
                    answers.Add(random.Next(10));
            }
            else
            {
                answers.Add(0);
            }
            if (labelAnswerB.Visible == true)
            {
                if ("B" == _correctAnswer)
                    answers.Add(random.Next(7, 12));
                else
                    answers.Add(random.Next(10));
            }
            else
            {
                answers.Add(0);
            }
            if (labelAnswerC.Visible == true)
            {
                if ("C" == _correctAnswer)
                    answers.Add(random.Next(7, 12));
                else
                    answers.Add(random.Next(10));
            }
            else
            {
                answers.Add(0);
            }
            if (labelAnswerD.Visible == true)
            {
                if ("D" == _correctAnswer)
                    answers.Add(random.Next(7, 12));
                else
                    answers.Add(random.Next(10));
            }
            else
            {
                answers.Add(0);
            }

            int total = 0;
            foreach(int i in answers)
            {
                total += i;
            }
            labelAnswerA.Text += "    " + Math.Round(((answers[0] * 100.0) / total),2).ToString() + "%";
            labelAnswerB.Text += "    " + Math.Round(((answers[1] * 100.0) / total), 2).ToString() + "%";
            labelAnswerC.Text += "    " + Math.Round(((answers[2] * 100.0) / total), 2).ToString() + "%";
            labelAnswerD.Text += "    " + Math.Round(((answers[3] * 100.0) / total), 2).ToString() + "%";

            labelPublic.Text = "X";
            labelPublic.ForeColor = Color.Red;
            labelPublic.Font = new Font("Consolas", 80.0f, FontStyle.Bold);
            labelPublic.Location = new Point(130, 48);

        }

        private void labelCallFriend_Click(object sender, EventArgs e)
        {
            if (_callAFriendPressed == true)
                return;
            _callAFriendPressed = true;
            Random rand = new Random();
            int value = rand.Next(4);
            int number = Convert.ToInt32(_correctAnswer[0] - 'A');

            if (_fiftyFiftyPressed)
            {
                switch (_correctAnswer)
                {
                    case "A":
                            labelAnswerA.ForeColor = Color.Gold;
                        break;
                    case "B":
                            labelAnswerB.ForeColor = Color.Gold;
                        break;
                    case "C":
                            labelAnswerC.ForeColor = Color.Gold;
                        break;
                    case "D":
                            labelAnswerD.ForeColor = Color.Gold;
                        break;
                }
            }
            else
            {
                if (value == 0)
                {
                    switch (_correctAnswer)
                    {
                        case "A":
                            labelAnswerA.ForeColor = Color.Gold;
                            break;
                        case "B":
                            labelAnswerB.ForeColor = Color.Gold;
                            break;
                        case "C":
                            labelAnswerC.ForeColor = Color.Gold;
                            break;
                        case "D":
                            labelAnswerD.ForeColor = Color.Gold;
                            break;
                    }
                }
                else
                {

                    while (true)
                    {
                        if (value != number)
                        {
                            switch (value)
                            {
                                case 0:
                                    labelAnswerA.ForeColor = Color.Gold;
                                    break;
                                case 1:
                                    labelAnswerB.ForeColor = Color.Gold;
                                    break;
                                case 2:
                                    labelAnswerC.ForeColor = Color.Gold;
                                    break;
                                case 3:
                                    labelAnswerD.ForeColor = Color.Gold;
                                    break;

                            }
                            break;
                        }
                    }
                }
            }

            labelCallFriend.Text = "X";
            labelCallFriend.ForeColor = Color.Red;
            labelCallFriend.Font = new Font("Consolas", 80.0f, FontStyle.Bold);
            labelCallFriend.Location = new Point(229, 48);
        }

        private void labelMoney10_Click(object sender, EventArgs e)
        {

        }
    }
}
