using EksamensProjekt20.MapNManager;
using EksamensProjekt20.SecondaryAttacks;
using EksamensProjekt20.UI;
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
        private GameManager gameManager;
        
        
        public override void Death()
        {
            if (currentHealth <= 0)
            {
                gameManager.EndRun();
            }
            
            base.Death();
        }
        public void Move(Vector2 velocity)
        {
            moveVector = velocity;
            if(velocity.X > 0)
            {
                lookingRight = true;
            }
            else if (velocity.X < 0)
            {
                lookingRight = false;
            }
        }
        public override void Update(double deltaTime)
        {
            this.Death();
            base.Update(deltaTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(ContentCollection.font, tag, new Vector2(70, 80), Color.Black);
            base.Draw(spriteBatch);
        }

        public virtual void SecAttack()
        {
            secondaryAttack.Attack();
            secondaryDelay = secondaryCD;
        }
        
    }
}
