using PCManGame.GamePlay;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public object playerMove(object data)
        {
            return _strategy.TakeAction(data);
        }


    }
}
