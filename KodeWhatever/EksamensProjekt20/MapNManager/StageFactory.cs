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
                case 4:
                    tempList.Add(new NormalPlatform(new Vector2(50, 550), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(150, 550), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(249, 550), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(346, 550), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(446, 550), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(624, 529), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(624, 440), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(624, 351), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(624, 261), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(624, 627), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(624, 726), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(557, 755), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(461, 755), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(363, 755), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(265, 755), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(195, 755), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(19, 620), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(19, 704), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(19, 804), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(19, 904), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(87, 934), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(187, 934), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(287, 934), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(383, 934), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(483, 934), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(583, 934), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(682, 934), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(781, 934), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(851, 904), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(851, 806), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(851, 706), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(851, 610), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(851, 515), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(781, 894), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(819, 857), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(820, 827), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(675, 735), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(660, 705), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(815, 617), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(824, 587), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(662, 498), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(921, 485), blockNumber, false));
                    tempList.Add(new Archibald(new Vector2(290, 673), blockNumber));
                    tempList.Add(new Blob(new Vector2(633, 858), blockNumber));
                    tempList.Add(new Blob(new Vector2(410, 863), blockNumber));
                    break;
                case 5:
                    tempList.Add(new NormalPlatform(new Vector2(50, 542), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(150, 542), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(249, 542), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(319, 512), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(387, 482), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(454, 512), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(484, 582), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(583, 582), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(681, 582), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(780, 582), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(878, 582), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(947, 552), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(977, 482), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(193, 418), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(82, 346), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(238, 282), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(397, 283), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(558, 282), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(698, 285), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(801, 270), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(920, 250), blockNumber, true));
                    tempList.Add(new Archibald(new Vector2(877, 500), blockNumber));
                    tempList.Add(new Archibald(new Vector2(776, 496), blockNumber));
                    tempList.Add(new Archibald(new Vector2(655, 495), blockNumber));
                    tempList.Add(new Archibald(new Vector2(563, 495), blockNumber));
                    break;
                case 6:
                    tempList.Add(new NormalPlatform(new Vector2(49, 548), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(45, 813), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(145, 813), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(245, 813), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(244, 550), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(345, 813), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(441, 813), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(509, 782), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(549, 782), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(588, 782), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(627, 782), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(665, 782), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(267, 749), blockNumber, true));
                    tempList.Add(new Blob(new Vector2(36, 730), blockNumber));
                    tempList.Add(new Blob(new Vector2(110, 735), blockNumber));
                    tempList.Add(new Blob(new Vector2(199, 729), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(705, 782), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(774, 752), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(804, 682), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(805, 597), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(806, 503), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(807, 410), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(808, 314), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(980, 154), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(980, 254), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(980, 353), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(950, 535), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(952, 84), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(854, 84), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(757, 84), blockNumber, false));
                    tempList.Add(new Archibald(new Vector2(742, 674), blockNumber));
                    break;
                case 7:
                    tempList.Add(new NormalPlatform(new Vector2(49, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(148, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(247, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(347, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(446, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(545, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(641, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(740, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(837, 553), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(907, 523), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(937, 453), blockNumber, false));
                    tempList.Add(new Archibald(new Vector2(548, 471), blockNumber));
                    tempList.Add(new Archibald(new Vector2(761, 470), blockNumber));
                    break;
                case 8:
                    tempList.Add(new NormalPlatform(new Vector2(50, 498), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(147, 498), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(211, 537), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(270, 577), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(337, 616), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(390, 654), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(434, 693), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(485, 693), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(553, 656), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(621, 618), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(674, 579), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(731, 542), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(785, 505), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(850, 476), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(907, 446), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(960, 446), blockNumber, false));
                    tempList.Add(new Archibald(new Vector2(475, 612), blockNumber));
                    break;
                case 9:
                    tempList.Add(new NormalPlatform(new Vector2(49, 947), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(148, 947), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(347, 947), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(377, 877), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(379, 783), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(381, 690), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(382, 598), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(384, 500), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(454, 470), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(553, 470), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(653, 470), blockNumber, false));
                    tempList.Add(new ClimbablePlatform(new Vector2(683, 400), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(684, 300), blockNumber, true));
                    tempList.Add(new ClimbablePlatform(new Vector2(685, 200), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(755, 170), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(178, 947), blockNumber, false));
                    tempList.Add(new Blob(new Vector2(616, 391), blockNumber));
                    tempList.Add(new Blob(new Vector2(550, 394), blockNumber));
                    tempList.Add(new NormalPlatform(new Vector2(949, 449), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(850, 449), blockNumber, false));
                    break;
                case 10:
                    tempList.Add(new NormalPlatform(new Vector2(50, 544), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(150, 544), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(251, 478), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(399, 427), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(324, 624), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(204, 694), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(428, 703), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(448, 554), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(625, 555), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(625, 699), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(541, 432), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(671, 369), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(757, 477), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(782, 636), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(529, 804), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(694, 839), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(833, 760), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(949, 677), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(916, 568), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(950, 497), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(880, 405), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(505, 312), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(685, 257), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(878, 285), blockNumber, false));
                    tempList.Add(new Archibald(new Vector2(429, 626), blockNumber));
                    tempList.Add(new Blob(new Vector2(778, 558), blockNumber));
                    tempList.Add(new Blob(new Vector2(709, 755), blockNumber));
                    tempList.Add(new Archibald(new Vector2(510, 236), blockNumber));
                    tempList.Add(new Blob(new Vector2(397, 351), blockNumber));
                    tempList.Add(new Blob(new Vector2(769, 399), blockNumber));
                    tempList.Add(new Blob(new Vector2(626, 478), blockNumber));
                    break;
                case 11:
                    tempList.Add(new NormalPlatform(new Vector2(49, 546), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(146, 546), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(246, 546), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(345, 546), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(443, 546), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(650, 545), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(750, 545), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(820, 516), blockNumber, true));
                    tempList.Add(new NormalPlatform(new Vector2(850, 463), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(949, 463), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(680, 446), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(392, 446), blockNumber, false));
                    tempList.Add(new NormalPlatform(new Vector2(536, 386), blockNumber, false));
                    tempList.Add(new Archibald(new Vector2(836, 388), blockNumber));
                    tempList.Add(new Blob(new Vector2(539, 310), blockNumber));
                    break;



            }
            return tempList;
        }

    }
}
