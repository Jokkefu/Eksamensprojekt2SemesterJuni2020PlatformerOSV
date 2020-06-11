using EksamensProjekt20.MapNManager;
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
        
        public override void Death()
        {

            base.Death();
        }
        public void Move(Vector2 velocity)
        {
            moveVector = velocity;
        }
        public override void Update(double deltaTime)
        {
            base.Update(deltaTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        public virtual void SecAttack()
        {
            secondaryAttack.Attack();
            secondaryDelay = secondaryCD;
        }
        
    }
}
