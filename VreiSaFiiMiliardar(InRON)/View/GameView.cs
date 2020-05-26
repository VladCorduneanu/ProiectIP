/**************************************************************************
 *                                                                        *
 *  File:        GameView.cs                                              *
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

namespace NView
{
    public partial class GameView : System.Windows.Forms.Form
    {
        // reference to view
        IView _viewer;
        // list of money labels
        private List<Label> _labels;
        // variable that show user seconds remaining
        private int _secondsRemaining;
        // variables to mark helping availability
        private bool _fiftyFiftyPressed;
        private bool _callAFriendPressed;
        private bool _publicPressed;
        // variable that containts the correct answer
        private string _correctAnswer;
        // variable that marks if a new questions exists
        private bool _nextQuestion;
        //variable to mark the current question number
        private int _currentQuestion;

        // constructor with parameters to set viewer and initialize object from interface
        public GameView(IView viewer)
        {
            _viewer = viewer;
            InitializeComponent();

            _labels = new List<Label>();

        }
 
        /// <summary>
        /// First initialize when form is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameView_Load(object sender, EventArgs e)
        {
            // initialize advice text
            labelHelp.Text = "Salut. Stii regulile,\n sunt simple: 15 intrebari," +
                             "\n30 de secunde intrebarea.\n Nu uita, ai parte si de ajutor\n" +
                             "Apasa start pentru a incepe.";

            // dezactivate objects from interface that will not be showed at first
            DeactivateStartGame();
        }

        /// <summary>
        /// Method that marks visibile to false for objects that will not be showed at first
        /// </summary>
        public void DeactivateStartGame()
        {
            // setting labels visibility for questions and answers to false
            labelAnswerA.Visible = false;
            labelAnswerB.Visible = false;
            labelAnswerC.Visible = false;
            labelAnswerD.Visible = false;
            labelQuestion.Visible = false;

            // setting labels visibility for helping to false
            labelFiftyFifty.Visible = false;
            labelCallFriend.Visible = false;
            labelPublic.Visible = false;

            // setting timer visibility to false
            labelTimer.Visible = false;
        }

        /// <summary>
        /// Method that marks visibile to true for objects that will not be showed at first
        /// </summary>
        public void ActivateStartGame()
        {
            // marking help as not used
            _publicPressed = false;
            _fiftyFiftyPressed = false;
            _callAFriendPressed = false;

            // marking time visibility to true
            labelTimer.Visible = true;
            
            // marking button start visibility and help visibility to false
            buttonStart.Visible = false;
            labelHelp.Visible = false;

            //setting answers and question visibility to true
            labelAnswerA.Visible = true;
            labelAnswerB.Visible = true;
            labelAnswerC.Visible = true;
            labelAnswerD.Visible = true;
            labelQuestion.Visible = true;

            // setting help visbility to true and set thei text to none
            labelFiftyFifty.Visible = true;
            labelCallFriend.Visible = true;
            labelPublic.Visible = true;
            labelFiftyFifty.Text = "";
            labelCallFriend.Text = "";
            labelPublic.Text = "";

            //initialize first question
            _currentQuestion = 0;

            //ading labels to label list
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

            // activate start game
            _viewer.StartGame();
        }

        /// <summary>
        /// Event for Start button of window
        /// </summary>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // setting backgrund
            BackgroundImage = global::View.Properties.Resources.in_game_image;

            // activate game objects
            ActivateStartGame();

            // bringing next question to the view 
            NewQuestion();

        }

        /// <summary>
        /// Method that checks what to show on screen depending to user choice and game status
        /// </summary>
        private void NewQuestion()
        {
            // getting new question
            QuestionModel question = _viewer.GetQuestion();

            // check if game is not won
            if (question != null)
            {
                // marking the status bar on the interface
                if (_currentQuestion > 0)
                {
                    // set status bar label color and text
                    _labels[_currentQuestion].BackColor = Color.Orange;
                    _labels[_currentQuestion].Text = "->" + _labels[_currentQuestion].Text;
                    _labels[_currentQuestion - 1].BackColor = Color.Transparent;
                    _labels[_currentQuestion - 1].Text = _labels[_currentQuestion - 1].Text.Substring(2);
                }
                else
                {
                    // set status bar label color and text for first question
                    _labels[_currentQuestion].BackColor = Color.Orange;
                    _labels[_currentQuestion].Text = "->" + _labels[_currentQuestion].Text;
                }

                // incrementing current question
                _currentQuestion++;

                // setting text for answer and questions from question onject
                labelQuestion.Text = question.Question;
                labelAnswerA.Text = question.AnswerA;
                labelAnswerB.Text = question.AnswerB;
                labelAnswerC.Text = question.AnswerC;
                labelAnswerD.Text = question.AnswerD;

                // setting color of the text
                labelAnswerA.ForeColor = Color.White;
                labelAnswerB.ForeColor = Color.White;
                labelAnswerC.ForeColor = Color.White;
                labelAnswerD.ForeColor = Color.White;

                // setting visibility of answers
                labelAnswerA.Visible = true;
                labelAnswerB.Visible = true;
                labelAnswerC.Visible = true;
                labelAnswerD.Visible = true;

                // setting the correct answer
                _correctAnswer = question.CorrectAnswer;

                // prepare timer to count
                _secondsRemaining = 30;
                timerQuestion.Interval = 1000;

                // activate timer
                timerQuestion.Enabled = true;

                // set timer look on interface
                labelTimer.Text = "30";
                labelTimer.ForeColor = Color.Green;

            }
            // check if game was won
            else
            {
                // dezactivate timer for question
                timerQuestion.Enabled = false;

                // activate end of the game
                _viewer.SetGameWon(true);
                _viewer.UpdateUserEvolution((_currentQuestion).ToString());
                _viewer.GoToGameEnd();
            }
        }

        /// <summary>
        /// Event for question timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            // decrementing second for user answer
            _secondsRemaining--;

            // checking availability of timer
            if (_secondsRemaining > 0)
            {
                // updating label text
                labelTimer.Text = _secondsRemaining.ToString();

                // changing color for the last 5 second
                if (_secondsRemaining < 6)
                {
                    labelTimer.ForeColor = Color.Red;
                }
            }
            // check if timer is to 0
            else
            {
                // dezactivate timer
                timerQuestion.Enabled = false;

                // check if user has a better score
                _viewer.UpdateUserEvolution((_currentQuestion-1).ToString());

                // setting end of the game
                _viewer.SetGameWon(false);
                _viewer.GoToGameEnd();
            }
        }

        /// <summary>
        /// Method to display the correct answer
        /// </summary>
        private void QuestionResponse()
        {
            // marking the color of the correct answer
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

            // dezactivate question timer
            timerQuestion.Enabled = false;

            // preparing a timer of 3 seconds to show the correct answer to user
            timerResponse.Interval = 3000;

            // start show response timer
            timerResponse.Enabled = true;
        }

        /// <summary>
        /// Method for user choice A
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAnswerA_Click(object sender, EventArgs e)
        {
            // check if user answer match the correct answer
            if (_correctAnswer == "A")
            {
                _nextQuestion = true;

            }
            else
            {
                labelAnswerA.ForeColor = Color.Red;
                _nextQuestion = false;
            }

            // display the correct answer
            QuestionResponse();

        }

        /// <summary>
        /// Method for user choice B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAnswerB_Click(object sender, EventArgs e)
        {
            // check if user answer match the correct answer
            if (_correctAnswer == "B")
            {
                _nextQuestion = true;

            }
            else
            {
                labelAnswerB.ForeColor = Color.Red;
                _nextQuestion = false;
            }

            // display the correct answer
            QuestionResponse();
        }

        /// <summary>
        /// Method for user choice C
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAnswerC_Click(object sender, EventArgs e)
        {
            // check if user answer match the correct answer
            if (_correctAnswer == "C")
            {
                _nextQuestion = true;

            }
            else
            {
                labelAnswerC.ForeColor = Color.Red;
                _nextQuestion = false;
            }

            // display the correct answer
            QuestionResponse();
        }

        /// <summary>
        /// Method for user choice D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAnswerD_Click(object sender, EventArgs e)
        {
            // check if user answer match the correct answer
            if (_correctAnswer == "D")
            {
                _nextQuestion = true;

            }
            else
            {
                labelAnswerD.ForeColor = Color.Red;
                _nextQuestion = false;
            }

            // display the correct answer
            QuestionResponse();
        }


        /// <summary>
        /// Event for response timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerResponse_Tick(object sender, EventArgs e)
        {
            // check if user had achive the last question
            if (_nextQuestion == true)
            {
                // getting a new question for user
                NewQuestion();
            }
            else
            {
                // setting game won
                _viewer.SetGameWon(false);
                _viewer.UpdateUserEvolution((_currentQuestion - 1).ToString());
                _viewer.GoToGameEnd();
            }

            // setting timer for show the correct answer to false
            timerResponse.Enabled = false;
        }

        /// <summary>
        /// Method for fifty fifty help pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelFiftyFifty_Click(object sender, EventArgs e)
        {

            // check if help was pressed
            if (_fiftyFiftyPressed)
                return;

            // marking help as pressed
            _fiftyFiftyPressed = true;

            // removing two wrong answerw from interface
            int number = Convert.ToInt32(_correctAnswer[0] - 'A');
            int var;
            Random rand = new Random();
            int i = 0;
            while (i < 2)
            {
                var = rand.Next(4);

                // check if random is equal to correct answer to pass
                if (var == number)
                    continue;

                // chose what response to remove
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

            // marking help as used
            labelFiftyFifty.Text = "X";
            labelFiftyFifty.ForeColor = Color.Red;
            labelFiftyFifty.Font = new Font("Consolas", 80.0f, FontStyle.Bold);
            labelFiftyFifty.Location = new Point(30,48);
        }

        /// <summary>
        /// Method for public help pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelPublic_Click(object sender, EventArgs e)
        {
            // check if help was already pressed
            if (_publicPressed == true)
                return;

            // marking the help as pressed
            _publicPressed = true;

            // creating a statistic for each answer
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

            // creating percentage for each answer
            int total = 0;
            foreach(int i in answers)
            {
                total += i;
            }

            // display percentage on interface
            labelAnswerA.Text += "    " + Math.Round(((answers[0] * 100.0) / total),2).ToString() + "%";
            labelAnswerB.Text += "    " + Math.Round(((answers[1] * 100.0) / total), 2).ToString() + "%";
            labelAnswerC.Text += "    " + Math.Round(((answers[2] * 100.0) / total), 2).ToString() + "%";
            labelAnswerD.Text += "    " + Math.Round(((answers[3] * 100.0) / total), 2).ToString() + "%";

            // marking help as used
            labelPublic.Text = "X";
            labelPublic.ForeColor = Color.Red;
            labelPublic.Font = new Font("Consolas", 80.0f, FontStyle.Bold);
            labelPublic.Location = new Point(130, 48);

        }

        /// <summary>
        /// Method for call a friend help pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCallFriend_Click(object sender, EventArgs e)
        {
            // check if help was already pressed
            if (_callAFriendPressed == true)
                return;

            // marking help as pressed 
            _callAFriendPressed = true;

            // create a 3 of 4 statistic to get the correct answer
            Random rand = new Random();
            int value = rand.Next(4);
            int number = Convert.ToInt32(_correctAnswer[0] - 'A');

            // check if fifty fifty was already pressed
            if (_fiftyFiftyPressed)
            {
                switch (_correctAnswer)
                {
                    // set the color of answer picked by friend
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
                    // set the color of answer picked by friend
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
                    // set the color of answer picked by friend
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
                        value = rand.Next(4);
                    }
                }
            }


            // marking help as used
            labelCallFriend.Text = "X";
            labelCallFriend.ForeColor = Color.Red;
            labelCallFriend.Font = new Font("Consolas", 80.0f, FontStyle.Bold);
            labelCallFriend.Location = new Point(229, 48);
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
