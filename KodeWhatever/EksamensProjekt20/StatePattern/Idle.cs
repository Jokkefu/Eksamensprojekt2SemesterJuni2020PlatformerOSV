using EksamensProjekt20.Characters;
using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.StatePattern
{
    class Idle : IEnemyState
    {
        private Vector2 velocity;

        private Enemy enemy;

        double currenttime = Game1.gameTime.ElapsedGameTime.TotalSeconds;

        private bool turnRight;

        public void Enter(Enemy enemy)
        {
            this.enemy = enemy;
            //velocity = new Vector2(0.001f, 0);


        }
        private void Blockinfo()
        {
            foreach (StageBlock stageBlock in GameManager.currentStage.stageSetup)
            {
                foreach (GameObject gameObject in stageBlock.terrainSetup)
                {
                    if (gameObject.tag == "Terrain")
                    {
                        if ((this.enemy.gamePosition.X + (gameObject.spriteRect.Width * 2) > gameObject.spriteRect.Right && this.enemy.gamePosition.X - (gameObject.spriteRect.Width * 2) < gameObject.spriteRect.Left) && (this.enemy.spriteRect.Bottom + 30 > gameObject.gamePosition.Y && this.enemy.spriteRect.Bottom - 30 < gameObject.gamePosition.Y))
                        {
                            if (this.enemy.spriteRect.Right > gameObject.spriteRect.Right)
                            {
                                turnRight = false;
                            }

                            //venstre
                            else if (this.enemy.spriteRect.Left < gameObject.spriteRect.Left)
                            {

                                turnRight = true;

                            }


                        }
                    }
                }
            }
        }

        public void Execute(double deltatime)
        {
            Blockinfo();
            if (turnRight == true)
            {
                  velocity = new Vector2 (0.5f, 0);
                  enemy.moveVector = velocity;
            }
            if (turnRight == false)
            {
                velocity = new Vector2 (-0.5f, 0);
                enemy.moveVector = velocity;
            }
            
        }

        public void Exit()
        {
            
        }
    }
}
/*GameManager.currentStage
foreach (StageBlock stageBlock in currentStage.stageSetup)
                {
                    foreach (GameObject gameObject in stageBlock.terrainSetup)
                    {
                        if(gameObject.tag == "Terrain")
                        {
                            TerrainPiece temp = (TerrainPiece)gameObject;
                            //Kode her
                        }
                    }
                }
temp.gamePosition*/
