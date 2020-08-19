using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PCManGame
{
    public abstract class GameLevel
    {
        Map map;
        public CellFactory CellFactory { get; set; } = new CellFactory();
        public GameLevel(Map _map)
        {
            this.map = _map;
        }
        public void OpenMap(Map map,string path)
        {
            if (path != null)
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    InitMap(json);
                }
            }
        }
        public void InitMap(string json)
        {
            var details = Newtonsoft.Json.Linq.JObject.Parse(json);
            foreach (var child in details)
            {
                var cell = child.Value.ToObject<Cell>();
                map.arr[cell.M_Location, cell.N_Location] = CellFactory.GetCellObject(cell.Description);
            }
        }
    }
}
