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

namespace EksamensProjekt20
{
    class GameObject : ScreenObject
    {

        public string tag;
        public bool isGrounded;
        public Vector2 velocity;
        public Vector2 gamePosition;
        public float movementSpeed;

        public override void Update(GameTime gameTime)
        {
            Gravity(gameTime);
            Movement(gameTime);
            base.Update(gameTime);
        }

        public void GroundCollisionDetection(GameObject other)
        {
            GameObject t = other;

            //t = terrain | this = player/enemy
            if (other.tag == "Terrain" && this.tag != "Terrain")
            {

                //Bottom Player Collision //(this.spriteRect.Top + this.velocity.Y < t.spriteRect.Bottom && this.spriteRect.Bottom > t.spriteRect.Bottom && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right)
                if (this.spriteRect.Bottom + this.velocity.Y > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Top && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right /*&& isGrounded == false*/)
                { 
                    int height = spriteRect.Bottom - other.spriteRect.Top;
                    gamePosition.Y -= height;

                    isGrounded = true;

                }
                //Top Player Collision //(this.spriteRect.Bottom + this.velocity.Y > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Top && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right /*&& isGrounded == false*/)
                if (this.spriteRect.Top + this.velocity.Y < t.spriteRect.Bottom && this.spriteRect.Bottom > t.spriteRect.Bottom && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right)
                {
                    velocity = new Vector2(velocity.X, velocity.Y - velocity.Y * 2);
                }
                //Right Player Collision
                if (this.spriteRect.Left + this.velocity.X < t.spriteRect.Right && this.spriteRect.Right > t.spriteRect.Right && this.spriteRect.Bottom > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Bottom /*&& isGrounded == false*/)
                {
                    int width = spriteRect.Left - other.spriteRect.Right;
                    gamePosition.X -= width;
                }
                //Left Player Collision
                if (this.spriteRect.Right + this.velocity.X > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Left && this.spriteRect.Bottom > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Bottom /*&&                                              isGrounded == false*/)
                {
                    int width = spriteRect.Right - other.spriteRect.Left;
                    gamePosition.X -= width;
                }
                else
                {
                    isGrounded = false;
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
                //c er den charecter vi kollidere med


                if (/*TOP*/c.spriteRect.Top >= this.spriteRect.Top &&/*BOTTOM*/ c.spriteRect.Bottom <= this.spriteRect.Bottom &&/*RIGHT*/ c.spriteRect.Right <= this.spriteRect.Right &&/*LEFT*/ c.spriteRect.Left >= this.spriteRect.Left) 
                {
                    c.AddBuff(new Burn(/*DMG*/10,/*DURATION SEC*/10,/*TICKCOUNT*/10,/*THE TARGET*/c));
                }
            }

        }
        private void Jump()
        {
            isGrounded = false;
            velocity = new Vector2(velocity.X, -2);
        }

        public void Gravity(GameTime gametime)
        {

            if (isGrounded == false)
            {
                velocity += new Vector2(0, (float)0.00001 * (float)gametime.ElapsedGameTime.TotalSeconds);
            }
            else if (isGrounded == true)
            {
                velocity.Y = velocity.Y - velocity.Y-0.00001f;

            }

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            screenPosition = gamePosition + Stage.stageVector - (spriteSize / 2);
            base.Draw(spriteBatch);
        }
        public void Movement(GameTime gameTime)
        {
<<<<<<< HEAD
            gamePosition += velocity * movementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds /12000;
=======
            gamePosition += velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
>>>>>>> 1cf97db13029e2c9110157482bb47af0a1048d6d
        }
    }
}
