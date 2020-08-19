using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.GamePlay
{
    public class MovmentValidation : IStrategy
    {
        public object TakeAction(object data)
        {

            var ch = data as string;
            if(ch.ToLower() == "w")
            {
                if (Player.GetPlayer.PosM - 1 < 0)
                {
                    return "Invalid Move";
                }
                else
                {
                    Player.GetPlayer.PosM -= 1;
                    return "Valid Move";
                }
            }
            else if (ch.ToLower() == "s")
            {
                if (Player.GetPlayer.PosM + 1 >= Map.M)
                {
                    return "Invalid Move";
                }
                else
                {
                    Player.GetPlayer.PosM += 1;
                    return "Valid Move";
                }
            }
            else if (ch.ToLower() == "d")
            {
                if (Player.GetPlayer.PosN + 1 >= Map.N)
                {
                    return "Invalid Move";
                }
                else
                {
                    Player.GetPlayer.PosN += 1;
                    return "Valid Move";
                }
            }
            else if (ch.ToLower() == "a")
            {
                if (Player.GetPlayer.PosN - 1 < 0)
                {
                    return "Invalid Move";
                }
                else
                {
                    Player.GetPlayer.PosN -= 1;
                    return "Valid Move";
                }
            }

            return "Invalid Input";
        }
    }
}
