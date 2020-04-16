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

        public Presenter(IView view)
        {
            Init(view);
        }
        public void Init(IView view) // Must be called in constructor
        {
            _view = view;
            
        }
    }
}
