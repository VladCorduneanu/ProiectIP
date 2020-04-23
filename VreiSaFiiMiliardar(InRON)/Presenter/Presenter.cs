using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPresenter
{
    public class Presenter : IPresenter
    {
        private IView _view;
        private IModelController _model;

        public Presenter(IView view, IModelController model)
        {
            Init(view,model);
        }
        
        public void Init(IView view, IModelController model)
        {
            _view = view;
            _model = model;

        }

        public void Login(string username, string password)
        {
            UserModel user = _model.Proxy().Login(username, password);

            if(user != null)
            {
                _view.AfterLogin(user);
                //logare cu succes
            }
            else
            {
                _view.LoginFailed();
                //login failed
            }
        }
    }
}
