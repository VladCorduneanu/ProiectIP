using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILoginModule
    {
        UserModel Login(string username, string password);
        bool AddUser(string username, string password);
        bool UpdateUser(UserModel user,string password);
        UserModel GetCurrentUser();
        
    }
}
