using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.Boxes
{
    public interface IBox
    {
        void CheckKey(Player player,Key key);
    }
}
