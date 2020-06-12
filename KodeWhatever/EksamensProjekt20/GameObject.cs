using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.Characters;
using EksamensProjekt20.Buffs;
using System.Runtime.CompilerServices;
using DiagnosticsUtils;

namespace EksamensProjekt20
{
    class GameObject : ScreenObject
    {

        public string tag;
        public bool isGrounded = false;
        public Vector2 velocity;
        public Vector2 moveVector;
        public Vector2 gamePosition;
        private Vector2 actualVelocity;
        public float movementSpeed;
        protected GameObject standingOn;
        protected bool gravityOn;
        protected float returnValue;

        public override void Update(double deltaTime)
        {
            if (gravityOn)
            {
                Gravity(deltaTime);
            }
            Movement(deltaTime);
            GameManager.CollisionCheck(this);
            base.Update(deltaTime);
        }

        public void GroundCollisionDetection(GameObject other)
        {
            //t = terrain | this = player/enemy
            if (other.tag == "Terrain" && tag != "Terrain")
            {

                //Bottom Player Collision //(this.spriteRect.Top + this.velocity.Y < t.spriteRect.Bottom && this.spriteRect.Bottom > t.spriteRect.Bottom && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right)
                if (this.spriteRect.Bottom + actualVelocity.Y > other.spriteRect.Top && this.spriteRect.Top < other.spriteRect.Top && this.spriteRect.Right > other.spriteRect.Left && this.spriteRect.Left < other.spriteRect.Right /*&& isGrounded == false*/)
                {
                    gamePosition.Y = other.gamePosition.Y - (spriteRect.Height + other.spriteRect.Height) / 2;
                    if (velocity.Y < 0) velocity.Y = 0;
                    isGrounded = true;
                    standingOn = other;
                }
                //Top Player Collision //(this.spriteRect.Bottom + this.velocity.Y > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Top && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right /*&& isGrounded == false*/)
                if (this.spriteRect.Top + actualVelocity.Y < other.spriteRect.Bottom && this.spriteRect.Bottom > other.spriteRect.Bottom && this.spriteRect.Right > other.spriteRect.Left && this.spriteRect.Left < other.spriteRect.Right)
                {
                    if (velocity.Y > 0) velocity.Y = 0;
                }
                //Right Player Collision
                if (this.spriteRect.Left + actualVelocity.X < other.spriteRect.Right && this.spriteRect.Right > other.spriteRect.Right && this.spriteRect.Bottom > other.spriteRect.Top && this.spriteRect.Top < other.spriteRect.Bottom /*&& isGrounded == false*/)
                {
                    gamePosition.X = other.gamePosition.X + (spriteRect.Width + other.spriteRect.Width) / 2;
                    velocity.X = 0;
                }
                //Left Player Collision
                if (spriteRect.Right + actualVelocity.X > other.spriteRect.Left && spriteRect.Left < other.spriteRect.Left && this.spriteRect.Bottom > other.spriteRect.Top && this.spriteRect.Top < other.spriteRect.Bottom /*&&                                              isGrounded == false*/)
                {
                    gamePosition.X = other.gamePosition.X - (spriteRect.Width + other.spriteRect.Width) / 2;
                    velocity.X = 0;
                }
            }
            


        }
        public void CharacterCollisionDetection(Character other1)
        {
            Character c = (Character)other1;
            if (other1.currentHealth >= 1)
            {
                // Y- = OP
                // Y+ = NED
                // X- = Venstre
                // X+ = Højre
                //c er den character vi kolliderer med


                if (/*TOP*/c.spriteRect.Top >= this.spriteRect.Top &&/*BOTTOM*/ c.spriteRect.Bottom <= this.spriteRect.Bottom &&/*RIGHT*/ c.spriteRect.Right <= this.spriteRect.Right &&/*LEFT*/ c.spriteRect.Left >= this.spriteRect.Left) 
                {
                    c.AddBuff(new Burn(/*DMG*/10,/*DURATION SEC*/10,/*TICKCOUNT*/10,/*THE TARGET*/c));
                }
            }

        }
        

        public void Gravity(double deltaTime)
        {
            
            if (isGrounded == false)
            {
                velocity += new Vector2(0, (float)(40 * deltaTime));
            }
            else
            {
                if (standingOn.spriteRect.Left > spriteRect.Right || standingOn.spriteRect.Right < spriteRect.Left || standingOn.spriteRect.Top > spriteRect.Bottom + 5)
                {
                    isGrounded = false;
                }
                else velocity.Y = 0;


            }

            if (gamePosition.Y >= Game1.screenSize.Y + 20) OutOfBounds();

        }
        public virtual void OutOfBounds()
        {
            gamePosition.Y = returnValue;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            screenPosition = gamePosition + Stage.stageVector - (spriteSize/2);
            base.Draw(spriteBatch);
        }
        public void Movement(double deltaTime)
        {
            actualVelocity = new Vector2((float)(moveVector.X * movementSpeed * deltaTime + velocity.X * deltaTime), (float)(moveVector.Y * movementSpeed * deltaTime + velocity.Y * deltaTime));
            gamePosition += actualVelocity;
            
        }
    }
}
