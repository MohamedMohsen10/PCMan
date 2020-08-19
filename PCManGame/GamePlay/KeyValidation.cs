using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.GamePlay
{
    public class KeyValidation : IStrategy
    {
        public object TakeAction(object data)
        {
            var item = Map.GetMap.arr[Player.GetPlayer.PosM, Player.GetPlayer.PosN];
            if (item is Key)
            {
                Player.GetPlayer.Keys.Add((Key)item);
                return $"We Found A new {item} key";
            }
            else
                return null;
        }
    }
}
