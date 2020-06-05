using EksamensProjekt20.Characters;
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
        

        public void EndRun()
        {

        }
        public void NextStage()
        {
            stageNumber++;
        }
        public void StartGame()
        {
            playerCharacter = new Warrior();
            stageNumber = 1;
        }
        public void OutOfBoundsCheck()
        {

        }
    }
}
