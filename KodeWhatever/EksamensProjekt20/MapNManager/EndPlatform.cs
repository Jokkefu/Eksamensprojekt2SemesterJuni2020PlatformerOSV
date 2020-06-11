using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class EndPlatform : StageBlock
    {

        public EndPlatform()
        {
            List<GameObject> tempList = new List<GameObject>();


            tempList.Add(new NormalPlatform(new Vector2(539, 509), 8, false));
            tempList.Add(new NormalPlatform(new Vector2(639, 509), 8, false));
            tempList.Add(new NormalPlatform(new Vector2(739, 509), 8, false));
            tempList.Add(new NormalPlatform(new Vector2(838, 479), 8, false));
            tempList.Add(new TriggerPlatform(new Vector2(938, 447), 8, false));
            foreach (GameObject gO in tempList)
            {
                gO.gamePosition.X -= 500;
            }
            terrainSetup = tempList;
        }
    }
}
