using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.GamePlay
{
    public class EnemyValidation : IStrategy
    {
        public object TakeAction(object data)
        {
            var item = Map.GetMap.arr[Player.GetPlayer.PosM, Player.GetPlayer.PosN];
            if (item is Enemy)
            {
                var enemy = item as Enemy;
                Console.WriteLine("Battle Begin");
                if (enemy.Fight(Player.GetPlayer))
                {
                    return $"Enemy is so Powerful we Lost";
                }
                else
                {
                    if (Player.GetPlayer.FighterState==FighterState.Alive)
                        return $"Well done, We still can fight";
                    else
                    {
                        return "I lost all of my power";
                    }
                }             
            }
            else
                return null;
        }
    }
}
