using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class StageFactory
    {
        Random random = new Random();


        public StageFactory()
        {

        }
        public Stage GenerateStage(int stageTheme)
        {
            Stage tempStage = new Stage(stageTheme);
            List<StageBlock> tempBlockList = new List<StageBlock>();
            for(int i = 0; i < 8; i++)
            {
                StageBlock tempBlock = new StageBlock();
                tempBlock.terrainSetup = GenerateTerrain(random.Next(8), i);
                tempBlockList.Add(tempBlock);
            }
            tempStage.stageSetup = tempBlockList;
            return tempStage;
        }
        public List<TerrainPiece> GenerateTerrain(int random, int blockNumber)
        {
            List<TerrainPiece> tempList = new List<TerrainPiece>();
            switch (random)
            {
                case 1:
                    tempList.Add(new NormalPlatform(new Vector2(202, 542), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(294, 543), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(387, 542), blockNumber));
                    break;
            }
            return tempList;
        }

    }
}
