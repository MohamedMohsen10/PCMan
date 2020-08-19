using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.Boxes
{
    public class GoldBox:IBox
    {
        public BoxState State { get; set; } = BoxState.Close;
        public string Type { get; } = "GoldenBox";

        public void CheckKey(Player player, Key key)
        {
            if (player != null && player.FighterState == FighterState.Alive )
            {
                if (key == Key.Gold && State == BoxState.Close)
                {
                    State = BoxState.Open;
                    player.Health += 50;
                    player.Weapon += 10;
                    player.Keys.Remove(key);
                }
            }
        }
        public override string ToString() => $"Gold";

    }
}
