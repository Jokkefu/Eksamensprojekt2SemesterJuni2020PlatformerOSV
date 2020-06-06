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

        private float cooldown;

        private float elapsed;

        private Enemy enemy;


        public void Enter(Enemy enemy)
        {
            this.enemy = enemy;
            enemy.movementSpeed = 50;
            elapsed = 0;
            cooldown = 3;

        }

        public void Execute()
        {
            //ChangeState
            elapsed += (float)Game1.gameTime.ElapsedGameTime.TotalSeconds;

            if (elapsed >= cooldown)
            {
                enemy.ChangeState(new Attack());
            }
        }

        public void Exit()
        {
            
        }
    }
}
