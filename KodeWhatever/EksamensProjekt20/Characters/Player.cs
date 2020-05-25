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
        private Texture2D sprite;

        private float speed;

        private Vector2 position;

        private Vector2 origin;

        public Player(Vector2 startPos)
        {
            this.position = startPos;
        }

        public void Move(Vector2 velocity)
        {
            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }

            velocity *= speed;
            position += (velocity)
        }

        protected SecondaryAttacks secondaryAttacks;
    }
}
