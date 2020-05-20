/**************************************************************************
 *                                                                        *
 *  File:        QuestionModel.cs                                         *
 *  Atuhors:     Baciu H. Alexandru                                       *
 *  Contributions: The authors' contribution depends on the               *
 *  implementation of tasks                                               *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class QuestionModel
    {
        private int _id;
        private string _question;
        private string _answerA;
        private string _answerB;
        private string _answerC;
        private string _answerD;
        private string _correctAnswer;
        private int _level;

        public QuestionModel(int id, string question, string answerA, string answerB, string answerC, string answerD, string correctAnswer, int level)
        {
            this._id = id;
            this._question = question;
            this._answerA = answerA;
            this._answerB = answerB;
            this._answerC = answerC;
            this._answerD = answerD;
            this._correctAnswer = correctAnswer;
            this._level = level;
        }
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string Question
        {
            get
            {
                return this._question;
            }
            set
            {
                this._question = value;
            }
        }

        public string AnswerA
        {
            get
            {
                return this._answerA;
            }
            set
            {
                this._answerA = value;
            }
        }

        public string AnswerB
        {
            get
            {
                return this._answerB;
            }
            set
            {
                this._answerB = value;
            }
        }

        public string AnswerC
        {
            get
            {
                return this._answerC;
            }
            set
            {
                this._answerC = value;
            }
        }

        public string AnswerD
        {
            get
            {
                return this._answerD;
            }
            set
            {
                this._answerD = value;
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return this._correctAnswer;
            }
            set
            {
                this._correctAnswer = value;
            }
        }

        public int Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("");
            stringBuilder.Append("Id: " + this._id + "\n");
            stringBuilder.Append("Question: " + this._question + "\n");
            stringBuilder.Append("A: " + this._answerA + "\n");
            stringBuilder.Append("B: " + this._answerB + "\n");
            stringBuilder.Append("C: " + this._answerC + "\n");
            stringBuilder.Append("D: " + this._answerD + "\n");
            stringBuilder.Append("Answer: " + this._correctAnswer + "\n");
            stringBuilder.Append("Level: " + this._level + "\n");
            return stringBuilder.ToString();
        }
    }

}