using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.Levels
{
    public class Hard:GameLevel
    {

        public Hard(Map map)
            : base(map)
        {
            OpenMap(map, "..\\HardMap.json");
        }
    }
}
