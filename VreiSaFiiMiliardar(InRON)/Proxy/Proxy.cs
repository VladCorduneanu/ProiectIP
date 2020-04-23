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

        private UserModel _currentUser;

        public Proxy(IModelController modelController)
        {
            _modelController = modelController;
        }
        public UserModel AddUser(string username, string password)
        {
            int dummyId = 0;
            UserModel user = new UserModel(dummyId, username, password, "0");


            return user;
        }

        public UserModel GetCurrentUser()
        {
            return _currentUser;
        }

        public UserModel Login(string username, string password)
        {
            UserModel user =_modelController.UserDAO().GetUser(username);

            if (user != null && user.Password == password)
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
