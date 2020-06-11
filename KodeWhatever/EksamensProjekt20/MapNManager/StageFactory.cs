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
                    tempList.Add(new NormalPlatform(new Vector2(48, 529), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(145, 529), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(242, 529), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(342, 529), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(410, 499), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(479, 469), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(668, 640), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(598, 670), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(506, 670), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(261, 904), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(361, 904), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(459, 904), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(555, 904), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(652, 904), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(750, 904), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(850, 904), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(559, 873), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(920, 874), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(775, 751), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(951, 844), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(709, 670), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(861, 605), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(951, 533), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(983, 464), blockNumber, true));
                    tempList.Add(new Blob(new Vector2(478, 825), blockNumber));
                    tempList.Add(new Blob(new Vector2(863, 830), blockNumber));
                    tempList.Add(new Archibald(new Vector2(463, 394), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(669, 549), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(670, 457), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(671, 367), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(672, 279), blockNumber, true));
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
