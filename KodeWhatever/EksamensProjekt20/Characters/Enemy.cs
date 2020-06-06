using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.StatePattern;

namespace EksamensProjekt20.Characters
{
    class Enemy : Character
    {
        private IEnemyState currentState;

        public Enemy(Vector2 position, int block)        
        {
            gamePosition = new Vector2(position.X + (block*1000), position.Y);
            spriteSize = new Vector2(20, 50);
            ChangeState(new Idle());
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            currentState.Execute();
        }
        public void ChangeState(IEnemyState newEnemyState)
        {
            if (currentState != null)
            {
                currentState.Exit();
            }

            currentState.Enter(this);
        }
    }
}
