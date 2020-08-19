using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.Levels
{
    public class Medium:GameLevel
    {
        public Medium(Map map)
            :base(map)
        {
            OpenMap(map, "..\\MediumMap.json");
        }
    }
}
