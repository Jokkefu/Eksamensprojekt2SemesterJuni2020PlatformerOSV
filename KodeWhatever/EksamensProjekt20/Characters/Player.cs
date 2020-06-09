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
            if (isGrounded) moveVector = velocity;
            else moveVector = new Vector2(0, 0);
            
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }

        public virtual void SecAttack()
        {
            secondaryAttack.Attack();
            secondaryDelay = secondaryCD;
        }
        public void Jump(Vector2 velocity)
        {
            this.velocity = new Vector2(velocity.X, velocity.Y);
        }
    }
}
