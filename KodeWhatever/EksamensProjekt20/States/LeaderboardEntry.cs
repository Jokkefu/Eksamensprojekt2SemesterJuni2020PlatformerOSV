using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.States
{
    class LeaderboardEntry
    {
        public int kills;
        public string name;
        public LeaderboardEntry(int killSum, string userName)
        {
            kills = killSum;
            name = userName;
        }
        
    }
}
