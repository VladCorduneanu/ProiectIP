using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IView
    {
        /// <summary>
        /// Starts the Program through the viewer
        /// </summary>
        /// <returns> Status </returns>
        bool Init();
        void SetPresenter(IPresenter presenter);
        bool StartApplication();
        void Login(string username, string password);
        void AfterLogin(UserModel user);
        void LoginFailed();
    }
}
