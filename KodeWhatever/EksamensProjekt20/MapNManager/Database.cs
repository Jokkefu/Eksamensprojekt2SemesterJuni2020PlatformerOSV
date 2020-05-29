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
<<<<<<< HEAD
=======
        //public SQLite database;
>>>>>>> 99657528414d3a1f90e3f69333537516fb315705

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



            cmd = new SQLiteCommand("INSERT INTO Player (CurrentStageID) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Player (Highscore) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Player (TotalKills) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Player (CharacterKills) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Player (RunKills) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Player (Ranking) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Leaderboard (Ranking) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Leaderboard (CurrentStageID) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("INSERT INTO Game (CurrentStage) VALUES (placeholder)", connection);
            cmd.ExecuteNonQuery();


            cmd = new SQLiteCommand("SELECT * from Player", connection);
            var dataset = cmd.ExecuteReader();

            while (dataset.Read())
            {
                var id = dataset.GetInt
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
