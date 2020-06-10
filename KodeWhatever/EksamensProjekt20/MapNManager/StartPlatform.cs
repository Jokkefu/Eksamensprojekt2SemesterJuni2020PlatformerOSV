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
            List<TerrainPiece> tempList = new List<TerrainPiece>();

            tempList.Add(new NormalPlatform(new Vector2(395, 509), 0));
            tempList.Add(new NormalPlatform(new Vector2(295, 509), 0));
            tempList.Add(new NormalPlatform(new Vector2(196, 509), 0));
            tempList.Add(new NormalPlatform(new Vector2(156, 449), 0));
            tempList.Add(new NormalPlatform(new Vector2(156, 349), 0));
            tempList.Add(new NormalPlatform(new Vector2(156, 251), 0));
            tempList.Add(new NormalPlatform(new Vector2(156, 152), 0));

        }
    }
}
