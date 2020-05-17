using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLogin
{
    public class LoginModule : ILoginModule
    {
        // reference for accesing the other modules
        private IModelController _modelController;
        // current user of session
        private UserModel _currentUser;
        // key for encryption
        private string _encryptionKey = "cheie";

        /// <summary>
        /// Constructor with parameters
        /// ModelController for getting reference to DatabaseAccess
        /// </summary>
        /// <param name="modelController"></param>
        public LoginModule(IModelController modelController)
        {
            _modelController = modelController;
        }

        /// <summary>
        /// Method for Sign Up
        /// Pulbic method that encrypt the user password and send the user to database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true for succesful action</returns>
        public bool AddUser(string username, string password)
        {
            int dummyId = 0;

            // encrypt password
            string encryptedPassword = Cryptography.Encrypt(password, _encryptionKey);

            // creating to user
            UserModel user = new UserModel(dummyId, username, encryptedPassword, "0");

            // setting the new user
            if (user != null)
            {
                _currentUser = user;
            }

            // call the database module for storing the user, and return result
            return _modelController.UserDAO().InsertUser(user);
        }

        /// <summary>
        /// Getter for current user
        /// </summary>
        /// <returns>The user of the session</returns>
        public UserModel GetCurrentUser()
        {
            return _currentUser;
        }

        /// <summary>
        /// Method for Log in
        /// Checks if user is valid
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Current user or null in case of failure</returns>
        public UserModel Login(string username, string password)
        {
            // getting user by username fromd database
            UserModel user =_modelController.UserDAO().GetUser(username);

            // encrypt the password that user has provided in interface
            string encryptedPassword = Cryptography.Encrypt(password, _encryptionKey);

            // check if user exists in the database and if the password are the same
            if (user != null && user.Password == encryptedPassword)
            {
                // setting current user
                _currentUser = user;

                return user;
            }
            
            return null;
        }
        
        /// <summary>
        /// Method for changing passwords from settings
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns>true in case of succesfull operation</returns>
        public bool UpdateUser(UserModel user, string password)
        {
            // encrypt the new password
            string encryptedPassword = Cryptography.Encrypt(password, _encryptionKey);

            // update the user password into database
            _modelController.UserDAO().UpdatePassword(user, encryptedPassword);

            return true;
        }
    }
}
