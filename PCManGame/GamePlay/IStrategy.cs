using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.GamePlay
{
    public interface IStrategy
    {
        object TakeAction(object data);
    }
}
