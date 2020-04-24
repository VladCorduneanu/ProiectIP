﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IView
    {
        /// <summary>
        /// Starts the Program through the viewer
        /// </summary>
        /// <returns> Status </returns>
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
        QuestionModel GetQuestion();
        bool GetGameWon();
        void SetGameWon(bool value);

    }
}
