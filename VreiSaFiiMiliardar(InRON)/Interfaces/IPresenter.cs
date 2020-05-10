using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPresenter
    {
        void Init(IView view, IModelController model);
        bool Login(string username, string password);
        bool SignUp(string username, string password);
        void StartGame();
        bool UpdateUserEvolution(string evolution);
        QuestionModel GetQuestion();
        void DeleteAccount();
        void ChangePassword(string password);
        void ResetScore();
        string GetRankingTable();
        string GetUsername();
    }
}
