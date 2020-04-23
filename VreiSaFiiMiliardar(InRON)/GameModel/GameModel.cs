using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGameModel
{
    public class GameModel:IGameModel
    {
        private IModelController _modelController;

        public GameModel(IModelController modelController)
        {
            _modelController = modelController;
        }
    }
}
