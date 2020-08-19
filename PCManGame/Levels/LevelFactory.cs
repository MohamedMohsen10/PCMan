using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.Levels
{
    public class LevelFactory
    {
        public static GameLevel GetLevel(string levelType, Map map)
        {
            if (levelType == null)
            {
                return null;
            }
            else if (levelType.ToLower() == "easy")
            {
                return new Easy(map);
            }
            else if (levelType.ToLower() == "medium")
            {
                return new Medium(map);
            }

            else if (levelType.ToLower() == "hard")
            {
                return new Hard(map);
            }
            return null;
        }
    }
}
