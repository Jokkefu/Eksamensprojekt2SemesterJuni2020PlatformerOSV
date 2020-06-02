using EksamensProjekt20.SecondaryAttacks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Player : Character
    {

        private float speed;

        private Vector2 origin;

        

        public Player()
        {
            speed = 100;
        }

        public void Move(Vector2 velocity)
        {
            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }

            velocity *= speed;
            gamePosition += (velocity * (float)Game1.gameTime.ElapsedGameTime.TotalSeconds);
        }

        protected SecondaryAttack secondaryAttack;
    }
}
