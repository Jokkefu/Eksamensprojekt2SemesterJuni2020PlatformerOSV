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

            var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Player (userID string PRIMARY KEY, CurrentStageID integer, Highscore integer, TotalKills integer);", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Leaderboard (userID string PRIMARY KEY, Ranking integer, Highscore integer, stagesCleared integer, FOREIGN KEY (userID) REFERENCES player(userID), FOREIGN KEY (Highscore) REFERENCES player(Highscore));", connection);
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

            var cmd = new SQLiteCommand($"INSERT INTO Player (userID, TotalKills) VALUES ({gm.playerID}, TotalKills + {GameManager.runKillSum})", connection);
            cmd.ExecuteNonQuery(); 
            
            cmd = new SQLiteCommand($"INSERT INTO Leaderboard (userID, Highscore, stagesCleared) VALUES ({gm.playerID}, {GameManager.runKillSum}, {gm.stageNumber})", connection);
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
