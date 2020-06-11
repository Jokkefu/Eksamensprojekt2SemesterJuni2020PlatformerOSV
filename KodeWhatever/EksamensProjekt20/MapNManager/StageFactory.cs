using EksamensProjekt20.Characters;
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
            tempBlockList.Add(new StartPlatform());
            for(int i = 0; i < 8; i++)
            {
                StageBlock tempBlock = new StageBlock();
                tempBlock.terrainSetup = GenerateTerrain(random.Next(1,2), i);
                tempBlockList.Add(tempBlock);
            }
            tempStage.stageSetup = tempBlockList;
            tempBlockList.Add(new EndPlatform());
            return tempStage;
        }
        public List<GameObject> GenerateTerrain(int random, int blockNumber)
        {
            List<GameObject> tempList = new List<GameObject>();
            switch (random)
            {
                case 1:
                    tempList.Add(new NormalPlatform(new Vector2(155, 419), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(255, 418), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(353, 419), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(452, 419), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(551, 419), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(650, 419), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(748, 419), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(55, 419), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(848, 420), blockNumber, false));
                    foreach(GameObject gO in tempList)
                    {
                        gO.gamePosition.Y += 100;
                    }
                    break;
                case 2:
                    
                    break;
            }
            return tempList;
        }

    }
}
