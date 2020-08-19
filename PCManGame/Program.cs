using Newtonsoft.Json;
using PCManGame.GamePlay;
using PCManGame.Levels;
using System;
using System.IO;

namespace PCManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Map map = Map.GetMap;
            GameLevel gameLevel = LevelFactory.GetLevel("Easy", map);
            Player player = Player.GetPlayer;
            Context context = new Context();
            Console.WriteLine("---------------------");
            Console.WriteLine("Welcome to our Game");
            Console.WriteLine("---------------------");
            Console.WriteLine("Welcome to Easy Mode");
            Console.WriteLine("use W, A, S, D for your player movement");
            Console.WriteLine($"Your map dimensions is {Map.M}, {Map.N}");
            Console.WriteLine("---------------------");
            
            while (player.FighterState != FighterState.Dead)
            {
                Console.WriteLine($"Your position is {player.PosM}, {player.PosN}");
                Console.WriteLine("Make your Move");
                input=Console.ReadLine();
                context.SetStrategy(new MovmentValidation());
                var move = context.playerMove(input);
                Console.WriteLine(move);
                if ((string)move != "Valid Move")
                {
                    continue;
                }
                context.SetStrategy(new KeyValidation());
                var key = context.playerMove(input);
                Console.WriteLine(key);
                if ((string)key != null)
                {
                    continue;
                }
                context.SetStrategy(new BoxValidation());
                var box = context.playerMove(input);
                Console.WriteLine(box);
                if(box != null)
                {
                    continue;
                }
                context.SetStrategy(new DiamondValidation());
                var diamond = context.playerMove(input);
                Console.WriteLine(diamond);
                if (diamond !=null)
                {
                    break;
                }
                context.SetStrategy(new EnemyValidation());
                var enemy = context.playerMove(input);
                Console.WriteLine(enemy);
                if (enemy != null)
                {
                    Console.WriteLine("Battle Summery");
                    Console.WriteLine($" Player Health: {player.Health}, Player Weapon: {player.Weapon}");
                }


            }
            Console.WriteLine("Game Over");
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
