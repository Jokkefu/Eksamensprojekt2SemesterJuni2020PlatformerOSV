using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class Database
    {
        public SQLite database;

        public void CreateTables()
        {
            var connection = new SQLiteConnection("Data Source=oom.db; Version=3;New=True");
            connection.Open();

            var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Player (userID integer PRIMARY KEY, CurrentStageID integer, Highscore integer, Totalkills integer, CharacterKills integer, RunKills integer, Ranking integer, FOREIGN KEY (CurrentStageID) REFERENCES game(CurrentStage));", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Leaderboard (Ranking integer PRIMARY KEY, userID integer, FOREIGN KEY (userID) REFERENCES player(userID));", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Game (CurrentStage integer PRIMARY KEY, userID integer, FOREIGN KEY (userID) REFERENCES player (userID));", connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public void InsertData()
        {

        }
        public void ShowLeaderBoard()
        {

        }

    }
}
