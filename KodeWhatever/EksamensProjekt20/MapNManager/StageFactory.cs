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
                tempBlock.terrainSetup = GenerateTerrain(1, i);
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
                    tempList.Add(new NormalPlatform(new Vector2(18, 471), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(111, 471), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(193, 447), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(275, 422), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(358, 452), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(434, 484), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(527, 482), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(614, 482), blockNumber));
                    break;
                case 2:
                    tempList.Add(new Archibald(new Vector2(636, 372), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(18, 471), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(111, 471), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(193, 447), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(275, 422), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(358, 452), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(434, 484), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(527, 482), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(614, 482), blockNumber));
                    break;
            }
            return tempList;
        }

    }
}
