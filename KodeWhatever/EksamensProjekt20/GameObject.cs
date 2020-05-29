using Microsoft.Xna.Framework;
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

        

        public bool CollisionDetection(GameObject other)
        {
            Buildingblocks b = (Buildingblocks)other;
            if (GameObject.tag == "Terrain")
            {
                //Bottom Player Collision
                if (p.Position.Y - p.Sprite.Height / 2 < this.position.Y + sprite.Height / 2 && p.Position.Y - p.Sprite.Height / 3 > this.position.Y + sprite.Height / 2 && p.Position.X - p.Sprite.Width / 3 * 1.40 < this.position.X + sprite.Width / 2 && p.Position.X + p.Sprite.Width / 3 * 1.40 > this.position.X - sprite.Width / 2)
                {
                    int height = CollisionBox.Bottom - other.CollisionBox.Top;
                    position.Y -= height;

                    isGrounded = true;

                }
                //Top Player Collision
                if (p.Position.Y + p.Sprite.Height / 2 > this.position.Y - sprite.Height / 2 && p.Position.X - p.Sprite.Width / 3 * 1.40 < this.position.X + sprite.Width / 2 && p.Position.X + p.Sprite.Width / 3 * 1.40 > this.position.X - sprite.Width / 2 && isGrounded == false)
                {
                    velocity = new Vector2(velocity.X, velocity.Y - velocity.Y * 2);
                }
                //Right Player Collision
                if (p.Position.X - sprite.Width / 2 >= this.position.X + sprite.Width / 2 && p.Position.X > this.position.X + sprite.Width / 2 && p.Position.Y + p.Sprite.Height / 3 > this.position.Y - sprite.Height / 2 && isGrounded == false)
                {
                    int width = CollisionBox.Right - other.CollisionBox.Left;
                    position.X -= width;
                }
                //Left Player Collision
                if (p.Position.X + sprite.Width / 2 <= this.position.X - sprite.Width / 2 && p.Position.X < this.position.X - sprite.Width / 2 && p.Position.Y + p.Sprite.Height / 3 > this.position.Y - sprite.Height / 2 && isGrounded == false)
                {
                    int width = CollisionBox.Left - other.CollisionBox.Right;
                    position.X -= width;
                }

            }
        }
        private void Jump()
        {
            isGrounded = false;
            velocity = new Vector2(velocity.X, -2);
        }

        private void Gravity(GameTime gametime)
        {
            if (isGrounded == false)
            {
                velocity += new Vector2(0, 2 * (float)gametime.ElapsedGameTime.TotalSeconds);
            }
            else
            {
                velocity = Vector2.Zero;
            }

        }
    }
}
