using EksamensProjekt20.Characters;
using EksamensProjekt20.States;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class Database
    {
        private GameManager gm;
        public Database(GameManager gamemanager)
        {
            gm = gamemanager;
        }
        public void CreateTables()
        {
            var connection = new SQLiteConnection("Data Source=oom.db; Version=3;New=True");
            connection.Open();

            var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Player (userID string PRIMARY KEY, CurrentStageID integer, Highscore integer, Totalkills integer, CharacterKills integer, RunKills integer, Ranking integer, FOREIGN KEY (CurrentStageID) REFERENCES game(CurrentStage));", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Leaderboard VARCHAR 10 (userID string PRIMARY KEY, Ranking integer, FOREIGN KEY (userID) REFERENCES player(userID), FOREIGN KEY (Highscore) REFERENCES player(Highscore), FOREIGN KEY (CurrentStageID) REFERENCES player(CurrentStageID));", connection);
            cmd.ExecuteNonQuery();
          
            connection.Close();
        }
        public void InsertData()
        {
            var connection = new SQLiteConnection("Data Source=oom.db; Version=3;New=True");
            connection.Open();

            //cmd = new SQLiteCommand("INSERT INTO Player (TotalKills) VALUES (placeholder)", connection);
            //cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Player (CharacterKills) VALUES (placeholder)", connection);
            //cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Player (Ranking) VALUES (placeholder)", connection);
            //cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Leaderboard (Ranking) VALUES ()", connection);
            //cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Game (CurrentStage) VALUES (placeholder)", connection);
            //cmd.ExecuteNonQuery();

            var cmd = new SQLiteCommand($"INSERT INTO Player (CurrentStageID) VALUES ({gm.stageNumber})", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("SELECT (Highscore) from Player", connection);
            var dataSet = cmd.ExecuteReader();
            bool newHighScore = false;
            while (dataSet.Read())
            {
                int currScore = dataSet.GetInt32(0);
                if (currScore > GameManager.runKillSum)
                {
                    newHighScore = true;
                }
            }
            if (newHighScore)
            {
                cmd = new SQLiteCommand($"INSERT INTO Player (Highscore) VALUES ({GameManager.runKillSum})");
                cmd.ExecuteNonQuery();
            }

            cmd = new SQLiteCommand($"INSERT INTO Player (RunKills) VALUES (RunKills + {GameManager.runKillSum})", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand($"INSERT INTO Leaderboard (CurrentStageID) VALUES ({gm.stageNumber})", connection);
            cmd.ExecuteNonQuery();



            connection.Close();
        }
        public List<LeaderboardEntry> GetLeaderboard()
        {

            var connection = new SQLiteConnection("Data Source=oom.db; Version=3;New=True");
            connection.Open();

            var cmd = new SQLiteCommand($"SELECT * from Leaderboard");
            var dataSet = cmd.ExecuteReader();
            List<LeaderboardEntry> leaderList = new List<LeaderboardEntry>();
            while (dataSet.Read())
            {
                leaderList.Add(new LeaderboardEntry(dataSet.GetInt32(4),dataSet.GetString(0)));
            }

            connection.Close();
            return leaderList;
        }

    }
}
