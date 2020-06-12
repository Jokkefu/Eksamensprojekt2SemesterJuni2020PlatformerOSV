using EksamensProjekt20.Characters;
using EksamensProjekt20.CommandPattern;
using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.StatePattern
{
    class Attack : IEnemyState
    {
        private Vector2 velocity;

        private Enemy enemy;

        private bool PlayerRight;

        public void Enter(Enemy enemy)
        {
            this.enemy = enemy;
            //velocity = new Vector2(0.001f, 0);

        }

        public void Execute(double deltatime)
        {
            //Player er til venstre
            if ((Game1.gm.playerCharacter.gamePosition.X + this.enemy.spriteRect.Width) > this.enemy.gamePosition.X && Game1.gm.playerCharacter.gamePosition.X < enemy.gamePosition.X + 800)
            {
                velocity = new Vector2(3, 0);
                enemy.moveVector = velocity;
                PlayerRight = false;
                //Player er over enemy
                if (Game1.gm.playerCharacter.spriteRect.Bottom < this.enemy.spriteRect.Bottom)
                {
                    Blockinfo();
                }
            }
            //Player er til højre
            if ((Game1.gm.playerCharacter.gamePosition.X + this.enemy.spriteRect.Width) < this.enemy.gamePosition.X && Game1.gm.playerCharacter.gamePosition.X > enemy.gamePosition.X - 800)
            {
                velocity = new Vector2(-3, 0);
                enemy.moveVector = velocity;
                PlayerRight = true;
                //Player er over enemy
                if (Game1.gm.playerCharacter.spriteRect.Bottom < this.enemy.spriteRect.Bottom)
                {
                    Blockinfo();
                }
            }


        }
        private void Blockinfo()
        {
            foreach (StageBlock stageBlock in GameManager.currentStage.stageSetup)
            {
                foreach (GameObject gameObject in stageBlock.terrainSetup)
                {
                    if (gameObject.tag == "Terrain")
                    {
                        //Detection Range
                        if ((this.enemy.gamePosition.X + 200) > gameObject.spriteRect.Right && (this.enemy.gamePosition.X - 200) < gameObject.spriteRect.Left && (this.enemy.spriteRect.Bottom + 30) > gameObject.gamePosition.Y && (this.enemy.spriteRect.Bottom - 30) < gameObject.gamePosition.Y)
                        {
                        //Spilleren er oppe til højre
                           if (PlayerRight == true && this.enemy.spriteRect.Right > gameObject.spriteRect.Right || this.enemy.spriteRect.Bottom > Game1.gm.playerCharacter.spriteRect.Bottom)
                           {
                                enemy.Jump(new Vector2(0, -130));
                           }
                        //Spilleren er opppe til venstre
                           if (PlayerRight == false && this.enemy.spriteRect.Left < gameObject.spriteRect.Left || this.enemy.spriteRect.Bottom > Game1.gm.playerCharacter.spriteRect.Bottom)
                           {
                                enemy.Jump(new Vector2(0, -130));
                           }


                        }
                    }
                }
            }
        }
    
        public void Exit()
        {

        }
    }
}
