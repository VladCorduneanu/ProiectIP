﻿/**************************************************************************
 *                                                                        *
 *  File:        IView.cs                                                 *
 *  Atuhors:     Baciu H. Alexandru, Corduneanu Vlad, Haralamb Marian     *
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
    public interface IView
    {
        bool Init();
        void SetPresenter(IPresenter presenter);
        bool StartApplication();
        bool Login(string username, string password);
        bool SignUp(string username, string password);
        void GoToSignUp();
        void GoToLogIn();
        void GoToMenu();
        void GoToGame();
        void GoToGameEnd();
        void StartGame();
        void GotoSettings();
        void GotoRanking();
        QuestionModel GetQuestion();
        bool GetGameWon();
        void SetGameWon(bool value);
        void DeleteAccount();
        void ChangePassword(string password);
        void ResetScore();
        bool UpdateUserEvolution(string evolution);
        string GetRankingTable();
        string GetUsername();

    }
}
