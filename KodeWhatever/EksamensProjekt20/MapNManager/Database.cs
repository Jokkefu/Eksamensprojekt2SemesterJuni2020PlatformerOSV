using EksamensProjekt20.Characters;
using EksamensProjekt20.States;
using Microsoft.Xna.Framework.Graphics;
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

            cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Leaderboard VARCHAR 10 (userID integer PRIMARY KEY, Ranking integer, FOREIGN KEY (userID) REFERENCES player(userID), FOREIGN KEY (Highscore) REFERENCES player(Highscore), FOREIGN KEY (CurrentStageID) REFERENCES player(CurrentStageID));", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Game (CurrentStage integer PRIMARY KEY, userID integer, FOREIGN KEY (userID) REFERENCES player (userID));", connection);
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

            cmd = new SQLiteCommand("INSERT INTO Player (Highscore) VALUES (MAX(CurrentStageID) FROM Leaderboard)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand($"INSERT INTO Player (RunKills) VALUES ({GameManager.runKillSum})", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand($"INSERT INTO Leaderboard (CurrentStageID) VALUES ({gm.stageNumber})", connection);
            cmd.ExecuteNonQuery();



            connection.Close();
        }
        public void ShowLeaderBoard(SQLiteCommand command)
        {

            var connection = new SQLiteConnection("Data Source=oom.db; Version=3;New=True");
            connection.Open();

            command = new SQLiteCommand("CREATE UNIQUE INDEX Ranking ON Leaderboard(CurrentStageID); ");
            var dataset1 = command.ExecuteReader();

            command = new SQLiteCommand("CREATE VIEW leaderboard (Ranking) AS TEXT SELECT FROM Leaderboard ORDER BY CurrentStageID DESC", connection);
            var dataset = command.ExecuteReader();

            while (dataset.Read())
            {
                var CurrentStageID = dataset.GetInt32(0);
            }
            while (dataset1.Read())
            {
                var Ranking = dataset1.GetInt32(0);
            }

            connection.Close();
        }

    }
}
