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
        private IModelController _modelController;
        private string _encryptionKey = "cheie";
        private UserModel _currentUser;

        public LoginModule(IModelController modelController)
        {
            _modelController = modelController;
        }
        public bool AddUser(string username, string password)
        {
            int dummyId = 0;
            string encryptedPassword = Cryptography.Encrypt(password, _encryptionKey);

            UserModel user = new UserModel(dummyId, username, encryptedPassword, "0");

            if (user != null)
            {
                _currentUser = user;
            }

            return _modelController.UserDAO().InsertUser(user);
        }

        public UserModel GetCurrentUser()
        {
            return _currentUser;
        }

        public UserModel Login(string username, string password)
        {
            UserModel user =_modelController.UserDAO().GetUser(username);
            string encryptedPassword = Cryptography.Encrypt(password, _encryptionKey);

            if (user != null && user.Password == encryptedPassword)
            {
                _currentUser = user;
                return user;
            }
            
            return null;
        }
        
        public bool UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
