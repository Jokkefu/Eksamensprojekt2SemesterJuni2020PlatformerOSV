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
            stageNumber = 1;
        }
        public void OutOfBoundsCheck()
        {

        }
    }
}
