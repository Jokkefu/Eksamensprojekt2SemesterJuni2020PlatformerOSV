using EksamensProjekt20.Characters;
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
        private GameManager gm;
        public Database(GameManager gamemanager)
        {
            gm = gamemanager;
        }
        public void CreateTables()
        {
            var connection = new SQLiteConnection("Data Source=oom.db; Version=3;New=True");
            connection.Open();

            var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Player (userID integer PRIMARY KEY, CurrentStageID integer, Highscore integer, Totalkills integer, CharacterKills integer, RunKills integer, Ranking integer, FOREIGN KEY (CurrentStageID) REFERENCES game(CurrentStage));", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Leaderboard (userID integer PRIMARY KEY, Ranking integer, FOREIGN KEY (userID) REFERENCES player(userID), FOREIGN KEY (Highscore) REFERENCES player(Highscore), FOREIGN KEY (CurrentStageID) REFERENCES player(CurrentStageID));", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Game (CurrentStage integer PRIMARY KEY, userID integer, FOREIGN KEY (userID) REFERENCES player (userID));", connection);
            cmd.ExecuteNonQuery();



            cmd = new SQLiteCommand($"INSERT INTO Player (CurrentStageID) VALUES ({gm.stageNumber})", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Player (Highscore) VALUES (MAX(CurrentStageID) FROM Leaderboard)", connection);
            cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Player (TotalKills) VALUES (placeholder)", connection);
            //cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Player (CharacterKills) VALUES (placeholder)", connection);
            //cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand($"INSERT INTO Player (RunKills) VALUES ({gm.runKills})", connection);
            cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Player (Ranking) VALUES (placeholder)", connection);
            //cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Leaderboard (Ranking) VALUES ()", connection);
            //cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand($"INSERT INTO Leaderboard (CurrentStageID) VALUES ({gm.stageNumber})", connection);
            cmd.ExecuteNonQuery();

            //cmd = new SQLiteCommand("INSERT INTO Game (CurrentStage) VALUES (placeholder)", connection);
            //cmd.ExecuteNonQuery();


            cmd = new SQLiteCommand("SELECT * FROM Leaderboard ORDER BY CurrentStageID DESC", connection);
            var dataset = cmd.ExecuteReader();

            cmd = new SQLiteCommand("SELECT (RunKills) FROM Player", connection);
            var dataset1 = cmd.ExecuteReader();

            while (dataset.Read())
            {
                var CurrentStageID = dataset.GetInt32(0);
            }

          
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
