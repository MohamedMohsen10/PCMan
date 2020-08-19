using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.GamePlay
{
    public class DiamondValidation : IStrategy
    {
        public object TakeAction(object data)
        {
            var item = Map.GetMap.arr[Player.GetPlayer.PosM, Player.GetPlayer.PosN];
            if (item is string)
            {
                if ((string)item == "Diamond")
                return $"Congratulations Player wins - Diamond Item";
            }
            else
                return null;
            return null;
        }
    
    }
}
