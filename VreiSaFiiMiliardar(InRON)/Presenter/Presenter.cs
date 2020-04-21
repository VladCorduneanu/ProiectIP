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
    }
}
