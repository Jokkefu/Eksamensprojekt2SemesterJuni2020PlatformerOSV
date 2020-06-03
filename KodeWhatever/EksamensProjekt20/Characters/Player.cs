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
        public Player()
        {

            
        }

        public void Move(Vector2 velocity)
        {
            this.velocity += velocity;
        }

        protected SecondaryAttack secondaryAttack;
    }
}
