using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class GameManager
    {
        private Database database;
        public Stage currentStage;
        protected Player playerCharacter;
        public int stageNumber;
        public int runKills;
        private StageFactory stageFactory = new StageFactory();

        public void EndRun()
        {

        }
        public void NextStage()
        {
            //stageNumber++;
            currentStage = stageFactory.GenerateStage(stageNumber);
            playerCharacter.gamePosition = new Vector2(40, 100);
        }
        public void StartGame()
        {
            playerCharacter = new Warrior();
            stageNumber = 1;
            currentStage = stageFactory.GenerateStage(stageNumber);
        }
        public void OutOfBoundsCheck()
        {

        }
    }
}
