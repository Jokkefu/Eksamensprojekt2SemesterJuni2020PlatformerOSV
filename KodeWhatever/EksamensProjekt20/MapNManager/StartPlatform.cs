using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class StartPlatform : StageBlock
    {

        public StartPlatform()
        {

            List<GameObject> tempList = new List<GameObject>();
            tempList.Add(new NormalPlatform(new Vector2(395, 509), 0, false));
            tempList.Add(new NormalPlatform(new Vector2(295, 509), 0, false));
            tempList.Add(new NormalPlatform(new Vector2(196, 509), 0, false));
            tempList.Add(new NormalPlatform(new Vector2(156, 449), 0, true));
            tempList.Add(new NormalPlatform(new Vector2(156, 349), 0, true));
            tempList.Add(new NormalPlatform(new Vector2(156, 251), 0, true));
            tempList.Add(new NormalPlatform(new Vector2(156, 152), 0, true));
            foreach(GameObject gO in tempList)
            {
                gO.gamePosition.X -= 500;
            }
            terrainSetup = tempList;
        }
    }
}
