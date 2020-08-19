using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PCManGame.Levels
{
    public class Easy : GameLevel
    {
        public Easy(Map map)
            :base(map)
        {

            OpenMap(map, "..\\EasyMap.json");
        }

     
    }
}
