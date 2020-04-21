﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPresenter
    {
        void Init(IView view, IModelController model);
    }
}
