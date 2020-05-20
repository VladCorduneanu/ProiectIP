/**************************************************************************
 *                                                                        *
 *  File:        UserModel.cs                                             *
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
    public class UserModel
    {
        private int _id;
        private string _username;
        private string _password;
        private string _evolution;

        public UserModel(int id, string username, string password, string evolution)
        {
            this._id = id;
            this._username = username;
            this._password = password;
            this._evolution = evolution;
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

        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
        public string Evolution
        {
            get
            {
                return this._evolution;
            }
            set
            {
                this._evolution = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("");
            stringBuilder.Append("Id: " + this._id + "\n");
            stringBuilder.Append("Username: " + this._username + "\n");
            stringBuilder.Append("Password: " + this._password + "\n");
            stringBuilder.Append("Evolution: " + this._evolution + "\n");
            return stringBuilder.ToString();
        }
    }
}
