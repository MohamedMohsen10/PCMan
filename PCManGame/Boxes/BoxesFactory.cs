using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame.Boxes
{
    public class BoxesFactory
    {

        public IBox GetBox (string boxType)
        {
            if (boxType == null)
            {
                return null;
            }
            else if (boxType.ToLower() == "gold")
            {
                return new GoldBox();
            }
            else if (boxType.ToLower() == "silver")
            {
                return new SilverBox();
            }
            else if (boxType.ToLower() == "bronze")
            {
                return new BronzeBox();
            }
            else 
            return null;
                   
        }
    }
}
