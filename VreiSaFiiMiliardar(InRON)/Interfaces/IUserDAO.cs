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
        List<UserModel> GetUserRankings();
    }
}
