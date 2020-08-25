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
            Map map = Map.GetMap;
            GameLevel gameLevel = LevelFactory.GetLevel("Easy", map);
            Player player = Player.GetPlayer;
            Context context = new Context();
            Game game = new Game(player,context,gameLevel);

            
            game.DisplayBoard();
            game.Start();
           
            Console.WriteLine("Game Over");
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
