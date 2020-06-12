using EksamensProjekt20.Characters;
using EksamensProjekt20.CommandPattern;
using EksamensProjekt20.Projectiles;
using EksamensProjekt20.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class GameManager
    {
        private Database database;
        public static Stage currentStage;
        public Player playerCharacter;
        public int stageNumber;
        public static int runKillSum;
        private StageFactory stageFactory = new StageFactory();
        private InputHandler inputHandler = new InputHandler();
        private static List<Projectile> projectiles = new List<Projectile>();
        private static List<Projectile> rProjectiles = new List<Projectile>();
        private Game1 gameInstance;
        public static bool nextActive;
        public static bool endActive;

        public GameManager(Game1 gInstance)
        {
            gameInstance = gInstance;
        }
        private void EndRun()
        {
            database.InsertData();
            gameInstance.ChangeScene(0);
        }
        public void NextStage()
        {
            stageNumber++;
            currentStage = stageFactory.GenerateStage(1);
            currentStage.StartUnits(0);
            playerCharacter.gamePosition = new Vector2(200, 350);
            nextActive = false;
        }
        public void StartGame()
        {
            playerCharacter = new Warrior();
            stageNumber = 1;
            currentStage = stageFactory.GenerateStage(1);
            currentStage.StartUnits(0);
            currentStage.StartUnits(1);
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            currentStage.Draw(spriteBatch);
            playerCharacter.Draw(spriteBatch);
            foreach(Projectile proj in projectiles)
            {
                proj.Draw(spriteBatch);
            }
        }
        public void Update(float deltaTime)
        {
            foreach (StageBlock stageBlock in currentStage.stageSetup)
            {
                foreach (GameObject gameObject in stageBlock.terrainSetup)
                {
                    if(gameObject.tag == "TriggerPlatform")
                    {
                        CollisionCheck(gameObject);
                    }
                }
            }
            if (nextActive)
            {
                NextStage();
            }
            if (endActive)
            {
                EndRun();
            }
            inputHandler.Execute(playerCharacter);
            foreach (Projectile proj in projectiles)
            {
                proj.Update(deltaTime);
                CollisionCheck(proj);
            }

            foreach(Projectile projectile in rProjectiles)
            {
                projectiles.Remove(projectile);
            }
            rProjectiles = new List<Projectile>();
            currentStage.Update(playerCharacter);
            currentStage.Update(deltaTime);
        }
        
        public static void AddProjectile(Projectile projectile)
        {
            projectiles.Add(projectile);
        }

        public static void RemoveProjectile(Projectile projectile)
        {
            rProjectiles.Add(projectile);
        }
        public static void AddKill()
        {
            runKillSum++;
        }
        public static void CollisionCheck(GameObject originalObject)
        {
            if (currentStage != null)
            {
                foreach (StageBlock stageBlock in currentStage.stageSetup)
                {
                    foreach (GameObject gameObject in stageBlock.terrainSetup)
                    {
                        originalObject.GroundCollisionDetection(gameObject);
                        originalObject.CollisionDetection(gameObject);
                    }
                }
            }
        }
        public List<LeaderboardEntry> GetLeaderboard()
        {
            return database.GetLeaderboard();
        }
        public void DatabaseSetup()
        {
            database = new Database(this);
        }
    }
}
