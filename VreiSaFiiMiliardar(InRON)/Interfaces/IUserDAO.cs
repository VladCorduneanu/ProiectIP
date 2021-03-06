﻿/**************************************************************************
 *                                                                        *
 *  File:        IUserDAO.cs                                              *
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
    public interface IUserDAO
    {
        UserModel GetUser(string username);
        bool InsertUser(UserModel userModel);
        bool UpdatePassword(UserModel userModel, string newPassword);
        bool UpdateEvolution(string username, string newEvolution);
        string GetEvolution(string username);
        bool DeleteUser(UserModel userModel);
        List<UserModel> GetUserRankings();
    }
}
