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
            for(int i = 0; i < 8; i++)
            {
                StageBlock tempBlock = new StageBlock();
                tempBlock.terrainSetup = GenerateTerrain(random.Next(1,3), i);
                tempBlockList.Add(tempBlock);
            }
            tempStage.stageSetup = tempBlockList;
            return tempStage;
        }
        public List<GameObject> GenerateTerrain(int random, int blockNumber)
        {
            List<GameObject> tempList = new List<GameObject>();
            switch (random)
            {
                case 1:
                    tempList.Add(new Archibald(new Vector2(636, 372), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(18, 471), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(111, 471), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(193, 447), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(275, 422), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(358, 452), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(434, 484), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(527, 482), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(614, 482), blockNumber, true));
                    break;
                case 2:
                    tempList.Add(new NormalPlatform(new Vector2(9, 457), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(81, 489), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(146, 519), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(226, 550), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(308, 578), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(376, 498), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(404, 441), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(435, 442), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(523, 441), blockNumber, false));
                    tempList.Add(new Archibald(new Vector2(549, 332), blockNumber));
                    break;
            }
            return tempList;
        }

    }
}
