using EksamensProjekt20.Characters;
using EksamensProjekt20.CommandPattern;
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
        public Stage currentStage;
        protected Player playerCharacter;
        public int stageNumber;
        private static int runKillSum;
        private StageFactory stageFactory = new StageFactory();
        private InputHandler inputHandler = new InputHandler();
        private static List<Projectile> projectiles = new List<Projectile>();
        private static List<Projectile> rProjectiles = new List<Projectile>();

        public void EndRun()
        {

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
        public void Update(GameTime gameTime)
        {
            foreach (StageBlock stageBlock in currentStage.stageSetup)
            {
                foreach (GameObject gameObject in stageBlock.terrainSetup)
                {
                    playerCharacter.GroundCollisionDetection(gameObject);
                    foreach (GameObject go in stageBlock.terrainSetup)
                    {
                        if (gameObject != go)
                        {
                            gameObject.GroundCollisionDetection(go);
                        }
                            
                    }
                }
            }
            inputHandler.Execute(playerCharacter);
            foreach (Projectile proj in projectiles)
            {
                proj.Update(gameTime);
            }
            //currentStage.Update(gameTime);
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
    }
}
