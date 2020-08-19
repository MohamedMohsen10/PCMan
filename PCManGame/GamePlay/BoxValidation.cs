using PCManGame.Boxes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.GamePlay
{
    public class BoxValidation : IStrategy
    {
        public object TakeAction(object data)
        {
            var item = Map.GetMap.arr[Player.GetPlayer.PosM, Player.GetPlayer.PosN];
            if (item is IBox)
            {
                var box = item as IBox;
                Key? key=null;
                if (box is GoldBox)
                {
                    var gb = box as GoldBox;
                    if (gb.State == BoxState.Open)
                        return $"This {item} box already open";
                    if (Player.GetPlayer.Keys.Exists(k => k == Key.Gold))
                    {
                        key = Key.Gold;
                    }
                }
                else if (box is SilverBox)
                {
                    var gb = box as SilverBox;
                    if (gb.State == BoxState.Open)
                        return $"This {item} box already open";
                    if (Player.GetPlayer.Keys.Exists(k => k == Key.Silver))
                    {
                        key = Key.Silver;
                    }
                }
                else if (box is BronzeBox)
                {
                    var gb = box as BronzeBox;
                    if (gb.State == BoxState.Open)
                        return $"This {item} box already open";
                    if (Player.GetPlayer.Keys.Exists(k => k == Key.Bronze))
                    {
                        key = Key.Bronze;
                    }
                }
                else
                    key = null;
                if (key != null)
                {
                    box.CheckKey(Player.GetPlayer, (Key)key);
                }
                else
                    return $"We found a new {item.ToString()} Box but we don't have the Key";
                
                return $"Great we open a new {item.ToString()} Box";
            }
            else
                return null;
        }
    }
}
