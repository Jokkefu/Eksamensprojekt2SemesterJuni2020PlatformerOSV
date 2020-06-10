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

        public void EndRun()
        {
            database.InsertData();
        }
        public void NextStage()
        {
            //stageNumber++;
            currentStage = stageFactory.GenerateStage(stageNumber);
            playerCharacter.gamePosition = new Vector2(40, 0);
        }
        public void StartGame()
        {
            playerCharacter = new Warrior();
            stageNumber = 1;
            currentStage = stageFactory.GenerateStage(stageNumber);
        }
        public void OutOfBoundsCheck()
        {

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
            //currentStage.Update(gameTime);
            foreach(Projectile projectile in rProjectiles)
            {
                projectiles.Remove(projectile);
            }
            rProjectiles = new List<Projectile>();
            currentStage.UpdatePosition(playerCharacter);
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
                    }
                }
            }
        }
        private void StartUnits(int currentBlock)
        {
            foreach(GameObject gO in currentStage.stageSetup[currentBlock].terrainSetup)
            {
                if(gO.tag == "Character")
                {
                    Character temp = (Character)gO;
                    temp.StartThread();
                }
            }
        }
        public void DatabaseSetup()
        {
            database = new Database(this);
        }
    }
}
