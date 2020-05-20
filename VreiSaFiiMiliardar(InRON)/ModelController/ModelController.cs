/**************************************************************************
 *                                                                        *
 *  File:        ModelController.cs                                       *
 *  Atuhors:     Baciu H. Alexandru, Corduneanu Vlad                      *
 *  Contributions: The authors' contribution depends on the               *
 *  implementation of tasks                                               *
 *                                                                        *
 *                                                                        *
 *  Description: Contains logic for model of MVP design                   *
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
using DatabaseAcces;
using Interfaces;
using NLogin;

namespace NModelController
{
    /// <summary>
    /// This class is a bridge that contains 
    /// all the references that offers the
    /// functionality of Model
    /// </summary>
    public class ModelController:IModelController
    {
        // reference to login module
        private ILoginModule _login;
        // reference to question from database module
        private IQuestionDAO _questionDAO;
        // reference to user from database module
        private IUserDAO _userDAO;

        /// <summary>
        /// Getter for login module
        /// </summary>
        public ILoginModule LoginModule()
        {
            return _login;
        }

        /// <summary>
        /// Getter for question from database module
        /// </summary>
        public IQuestionDAO QuestionDAO()
        {
            return _questionDAO;
        }

        /// <summary>
        /// Getter for reference to user from database module
        /// </summary>
        public IUserDAO UserDAO()
        {
            return _userDAO;
        }

        /// <summary>
        /// Void Constructor 
        /// Instantiate all the modules
        /// </summary>
        public ModelController()
        {
            _login = new LoginModule(this);
            _questionDAO = new QuestionDAOService(Environment.CurrentDirectory + "/questions.db");
            _userDAO = new UserDAOService(Environment.CurrentDirectory + "/users.db");
        }
    }
}
