using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame
{
    public class Map
    {
        private static Map map;
        public static int M { get; set; } = 7;
        public static int N { get; set; } = 5;

        public object[,] arr { get; set; } = new object[M, N];  

        private static readonly object padlock = new object();

        private Map()
        {

        }

        public static Map GetMap
        {
            get
            {
                lock (padlock)
                {
                    if (map == null)
                    {
                        map = new Map();
                    }
                    return map;
                }
            }
        }
    }
}
