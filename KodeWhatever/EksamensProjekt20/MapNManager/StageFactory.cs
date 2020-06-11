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
                tempBlock.terrainSetup = GenerateTerrain(random.Next(1,3), i);
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
                    tempList.Add(new NormalPlatform(new Vector2(58, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(157, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(252, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(352, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(451, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(549, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(647, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(747, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(839, 613), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(804, 582), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(155, 568), blockNumber, true));
                    tempList.Add(new Archibald(new Vector2(501, 534), blockNumber));
                    tempList.Add(new Blob(new Vector2(295, 532), blockNumber));
                    tempList.Add(new Blob(new Vector2(694, 532), blockNumber));


                    break;
            }
            return tempList;
        }

    }
}
