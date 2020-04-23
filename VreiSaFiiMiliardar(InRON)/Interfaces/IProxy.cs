using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProxy
    {
        UserModel Login(string username, string password);
        UserModel AddUser(string username, string password);
        bool UpdateUser(UserModel user);
        UserModel GetCurrentUser();
        
    }
}
