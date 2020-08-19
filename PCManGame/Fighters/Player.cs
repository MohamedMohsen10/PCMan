using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame
{
    public sealed class Player:Fighter
    {
        public int PosM { get; set; } = 0;
        public int PosN { get; set; } = 0;
        private static Player player;
        public List<Key> Keys { get; set; } = new List<Key>();

        private static readonly object padlock = new object();

        private Player()
        {

        }

        public static Player GetPlayer
        {
            get
            {
                lock (padlock)
                {
                    if (player == null)
                    {
                        player = new Player();
                    }
                    return player;
                }
            }
        }


    }
}
