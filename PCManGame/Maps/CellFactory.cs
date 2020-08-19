using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame
{
    public class CellFactory
    {
        public Object GetCellObject(string cellType)
        {

            Boxes.BoxesFactory boxesFactory = new Boxes.BoxesFactory();

            if (cellType == null)
            {
                return null;
            }
            else if (cellType.ToLower() == "player")
            {
                return Player.GetPlayer;
            }
            else if (cellType.ToLower() == "enemy")
            {
                return new Enemy();
            }
            else if (cellType.ToLower() == "goldenkey")
            {
                var key = new Key();
                key = Key.Gold;
                return key;
            }
            else if (cellType.ToLower() == "silverkey")
            {
                var key = new Key();
                key = Key.Silver;
                return key;
            }
            else if (cellType.ToLower() == "bronzekey")
            {
                var key = new Key();
                key = Key.Bronze;
                return key;
            }
            else if (cellType.ToLower() == "goldenbox")
            {
                return boxesFactory.GetBox("gold");
            }
            else if (cellType.ToLower() == "bronzebox")
            {
                return boxesFactory.GetBox("bronze");
            }
            else if (cellType.ToLower() == "silverbox")
            {
                return boxesFactory.GetBox("silver");
            }
            else if (cellType.ToLower() == "diamond")
            {
                return "Diamond";
            }



            return null;

        }
    }
}
