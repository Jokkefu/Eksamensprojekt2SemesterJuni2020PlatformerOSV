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
        int mapCount = 3;
        

        public StageFactory()
        {
            
        }
        public Stage GenerateStage(int stageTheme)
        {
            int[] sequence = new int[8];
            Stage tempStage = new Stage(stageTheme);
            List<StageBlock> tempBlockList = new List<StageBlock>();
            tempBlockList.Add(new StartPlatform());
            for(int i = 0; i < 8; i++)
            {
                StageBlock tempBlock = new StageBlock();
                int rnd = random.Next(1, mapCount+1);
                sequence[i] = rnd;
                tempBlock.terrainSetup = GenerateTerrain(0, i);
                tempBlockList.Add(tempBlock);
            }
            tempStage.stageSetup = tempBlockList;
            tempBlockList.Add(new EndPlatform());
            tempStage.sequence = sequence;
            return tempStage;
        }
        public List<GameObject> GenerateTerrain(int rnd, int blockNumber)
        {
            List<GameObject> tempList = new List<GameObject>();
            
            switch (rnd)
            {
                default:
                    tempList.Add(new NormalPlatform(new Vector2(49, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(147, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(246, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(346, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(445, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(545, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(644, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(744, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(844, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(943, 526), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(967, 526), blockNumber, false));
                    break;

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
                    tempList.Add(new NormalPlatform(new Vector2(559, 873), blockNumber, false));
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
                    tempList.Add(new Archibald(new Vector2(501, 534), blockNumber));
                    tempList.Add(new Blob(new Vector2(295, 532), blockNumber));
                    tempList.Add(new Blob(new Vector2(694, 532), blockNumber));
                    break;
                case 3:
                    tempList.Add(new NormalPlatform(new Vector2(50, 552), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(49, 289), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(149, 552), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(248, 552), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(148, 289), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(247, 289), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(348, 552), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(346, 289), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(448, 552), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(524, 552), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(554, 482), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(555, 384), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(556, 284), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(376, 220), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(376, 122), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(406, 52), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(505, 52), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(604, 52), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(672, 52), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(702, 122), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(702, 221), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(702, 320), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(702, 420), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(702, 518), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(702, 618), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(672, 688), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(574, 688), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(326, 686), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(227, 686), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(356, 756), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(386, 826), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(483, 826), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(581, 826), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(679, 826), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(779, 826), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(848, 796), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(848, 702), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(848, 602), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(848, 502), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(848, 403), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(848, 303), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(845, 746), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(848, 618), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(850, 482), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(48, 687), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(78, 757), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(78, 856), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(78, 941), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(145, 971), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(245, 971), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(344, 971), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(441, 971), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(539, 971), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(638, 971), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(737, 971), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(836, 971), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(936, 971), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(966, 902), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(967, 804), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(968, 704), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(969, 604), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(970, 504), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(501, 688), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(692, 688), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(701, 550), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(701, 415), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(847, 327), blockNumber, false));
                    tempList.Add(new Blob(new Vector2(460, 475), blockNumber));
                    tempList.Add(new Archibald(new Vector2(773, 899), blockNumber));
                    tempList.Add(new Archibald(new Vector2(579, 898), blockNumber));
                    break;
            }
            return tempList;
        }

    }
}
