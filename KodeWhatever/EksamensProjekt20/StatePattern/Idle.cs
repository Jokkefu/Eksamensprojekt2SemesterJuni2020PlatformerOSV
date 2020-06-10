using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.StatePattern
{
    class Idle : IEnemyState
    {
        private Vector2 velocity;

        private float cooldown;

        private float elapsed;

        private Enemy enemy;


        public void Enter(Enemy enemy)
        {
            this.enemy = enemy;
            velocity = new Vector2(1, 0);
            elapsed = 0;
            cooldown = 3;

        }

        public void Execute()
        {
            enemy.moveVector = velocity;
            elapsed += (float)Game1.gameTime.ElapsedGameTime.TotalSeconds;

            if (elapsed >= cooldown)
            {
                //ChangeState
                enemy.ChangeState(new Attack());
            }
        }

        public void Exit()
        {
            
        }
    }
}
