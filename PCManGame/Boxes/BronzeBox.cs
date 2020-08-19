using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.Boxes
{
    public class BronzeBox:IBox
    {
        public BoxState State { get; set; } = BoxState.Close;
        public string Type { get; } = "BronzeBox";

        public void CheckKey(Player player, Key key)
        {
            if (player != null && player.FighterState == FighterState.Alive)
            {
                if (key == Key.Bronze && State == BoxState.Close)
                {
                    State = BoxState.Open;
                    player.Health += 20;
                    player.Keys.Remove(key);
                }
            }
        }
        public override string ToString() => $"Bronze";


    }
}
