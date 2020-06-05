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
        protected SecondaryAttack secondaryAttack;
        protected double secondaryDelay;
        protected float secondaryCD;
        public Player()
        {

            
        }
        public override void Death()
        {

            base.Death();
        }
        public void Move(Vector2 velocity)
        {
            this.velocity += velocity;

            if (velocity.Y == 0)
            {
                if (velocity.X >= 0)
                {
                    animation.Walking(true);
                }
                else
                {
                    animation.Walking(false);
                }
            }
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }

        public virtual void SecAttack()
        {
            secondaryAttack.Attack();
            secondaryDelay = secondaryCD;
        }
    }
}
