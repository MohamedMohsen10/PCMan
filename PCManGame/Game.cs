using PCManGame.GamePlay;
using PCManGame.Levels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame
{
    public class Game
    {
        string input;
        Player player;
        Context context;
        public GameLevel GameLevel { get; set; }

        public Game(Player _player, Context _context,GameLevel _gameLevel)
        {
            player = _player;
            context = _context;
            GameLevel = _gameLevel; 
        }

        public void DisplayBoard()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Welcome to our Game");
            Console.WriteLine("---------------------");
            Console.WriteLine("Welcome to Easy Mode");
            Console.WriteLine("use W, A, S, D for your player movement");
            Console.WriteLine($"Your map dimensions is {Map.M}, {Map.N}");
            Console.WriteLine("---------------------");

        }

        public void Start()
        {
            while (player.FighterState != FighterState.Dead)
            {
                Console.WriteLine($"Your position is {player.PosM}, {player.PosN}");
                Console.WriteLine("Make your Move");
                input = Console.ReadLine();
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
                if (box != null)
                {
                    continue;
                }
                context.SetStrategy(new DiamondValidation());
                var diamond = context.playerMove(input);
                Console.WriteLine(diamond);
                if (diamond != null)
                {
                    break;
                }
                context.SetStrategy(new EnemyValidation());
                var enemy = context.playerMove(input);
                Console.WriteLine(enemy);
                if (enemy != null)
                {
                    Console.WriteLine("Battle Summery");
                    Console.WriteLine($"Player Health: {(player.Health > 0 ? player.Health:0)}, Player Weapon: {player.Weapon}");
                }


            }
        }
    }
}
