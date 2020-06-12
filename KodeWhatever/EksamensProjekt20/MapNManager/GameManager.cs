using EksamensProjekt20.Characters;
using EksamensProjekt20.CommandPattern;
using EksamensProjekt20.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        public static Stage currentStage;
        public Player playerCharacter;
        public int stageNumber;
        public static int runKillSum;
        private StageFactory stageFactory = new StageFactory();
        private InputHandler inputHandler = new InputHandler();
        private static List<Projectile> projectiles = new List<Projectile>();
        private static List<Projectile> rProjectiles = new List<Projectile>();
        private Game1 gameInstance;
        public GameManager(Game1 gInstance)
        {
            gameInstance = gInstance;
        }
        public void EndRun()
        {
            database.InsertData();
        }
        public void NextStage()
        {
            stageNumber++;
            currentStage = stageFactory.GenerateStage(1);
            currentStage.StartUnits(0);
            playerCharacter.gamePosition = new Vector2(40, 0);
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
            inputHandler.Execute(playerCharacter);
            foreach (Projectile proj in projectiles)
            {
                proj.Update(deltaTime);
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
        public static void AddKill(Enemy unit)
        {
            foreach(StageBlock sB in currentStage.stageSetup)
            {
                foreach(GameObject gO in sB.terrainSetup)
                {
                    if(gO == unit)
                    {
                        sB.RemoveObject(unit);
                    }
                }
            }
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
                    }
                }
                
            }
        }
        
        public void DatabaseSetup()
        {
            database = new Database(this);
        }
    }
}
