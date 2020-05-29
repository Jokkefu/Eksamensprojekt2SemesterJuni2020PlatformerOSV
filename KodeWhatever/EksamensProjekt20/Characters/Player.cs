using EksamensProjekt20.SecondaryAttacks;
<<<<<<< HEAD
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
=======
>>>>>>> 99657528414d3a1f90e3f69333537516fb315705
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Player : Character
    {
<<<<<<< HEAD
        private Texture2D sprite;

        private float speed;

        private Vector2 position;

        private Vector2 origin;

        public Player(Vector2 startPos)
        {
            this.position = startPos;
            this.speed = 100;
        }

        public void Move(Vector2 velocity)
        {
            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }

            velocity *= speed;
            position += (velocity * Game1.DeltaTime);
        }

=======
>>>>>>> 99657528414d3a1f90e3f69333537516fb315705
        protected SecondaryAttack secondaryAttack;
    }
}
