using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class StageFactory
    {

        public StageFactory()
        {

        }
        public Stage GenerateStage(int stageTheme)
        {
            Stage tempStage = new Stage(stageTheme);
            List<StageBlock> tempBlock = new List<StageBlock>();
            for(int i = 0; i < 8; i++)
            {
                List<TerrainPiece> tempTerrain = new List<TerrainPiece>();
                tempTerrain.Add(new TerrainPiece());
                tempBlock[i].terrainSetup = tempTerrain;
            }
            tempStage.stageSetup = tempBlock;
            return tempStage;
        }
    }
}
