using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NProxy
{
    public class Proxy : IProxy
    {
        private IModelController _modelController;
        private string _encryptionKey = "cheie";
        private UserModel _currentUser;

        public Proxy(IModelController modelController)
        {
            _modelController = modelController;
        }
        public UserModel AddUser(string username, string password)
        {
            int dummyId = 0;
            string encryptedPassword = Cryptography.Encrypt(password, _encryptionKey);

            UserModel user = new UserModel(dummyId, username, encryptedPassword, "0");
            _modelController.UserDAO().InsertUser(user);

            return user;
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
            else if(user == null)
            {
                AddUser(username, password);
            }

            return null;
        }

        public bool UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
