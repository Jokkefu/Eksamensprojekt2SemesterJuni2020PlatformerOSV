using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Movement();
            base.Update(gameTime);
        }

        public void CollisionDetection(GameObject other)
        {
            TerrainPiece t = (TerrainPiece)other;
            if (other.tag == "Terrain")
            {
                //Bottom Player Collision
                if (t.gamePosition.Y - t.currentSprite.Height / 2 < this.gamePosition.Y + this.currentSprite.Height / 2 && t.gamePosition.Y - t.currentSprite.Height / 3 > this.gamePosition.Y + this.currentSprite.Height / 2 && t.gamePosition.X - t.currentSprite.Width / 3 * 1.40 < this.gamePosition.X + this.currentSprite.Width / 2 && t.gamePosition.X + t.currentSprite.Width / 3 * 1.40 > this.gamePosition.X - this.currentSprite.Width / 2)
                {
                    int height = spriteRect.Bottom - other.spriteRect.Top;
                    gamePosition.Y -= height;

                    isGrounded = true;

                }
                //Top Player Collision
                if (t.gamePosition.Y + t.currentSprite.Height / 2 > this.gamePosition.Y - this.currentSprite.Height / 2 && t.gamePosition.X - t.currentSprite.Width / 3 * 1.40 < this.gamePosition.X + this.currentSprite.Width / 2 && t.gamePosition.X + t.currentSprite.Width / 3 * 1.40 > this.gamePosition.X - this.currentSprite.Width / 2 && isGrounded == false)
                {
                    velocity = new Vector2(velocity.X, velocity.Y - velocity.Y * 2);
                }
                //Right Player Collision
                if (t.gamePosition.X - this.currentSprite.Width / 2 >= this.gamePosition.X + this.currentSprite.Width / 2 && t.gamePosition.X > this.gamePosition.X + currentSprite.Width / 2 && t.gamePosition.Y + t.currentSprite.Height / 3 > this.gamePosition.Y - this.currentSprite.Height / 2 && isGrounded == false)
                {
                    int width = spriteRect.Right - other.spriteRect.Left;
                    gamePosition.X -= width;
                }
                //Left Player Collision
                if (t.gamePosition.X + this.currentSprite.Width / 2 <= this.gamePosition.X - this.currentSprite.Width / 2 && t.gamePosition.X < this.gamePosition.X - currentSprite.Width / 2 && t.gamePosition.Y + t.currentSprite.Height / 3 > this.gamePosition.Y - this.currentSprite.Height / 2 && isGrounded == false)
                {
                    int width = spriteRect.Left - other.spriteRect.Right;
                    gamePosition.X -= width;
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
                velocity += new Vector2(0, 2 * (float)gametime.ElapsedGameTime.TotalSeconds);
            }

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            screenPosition = gamePosition + Stage.stageVector - (spriteSize / 2);
            base.Draw(spriteBatch);
        }
        public void Movement()
        {
            gamePosition += velocity * movementSpeed * (float)Game1.gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
