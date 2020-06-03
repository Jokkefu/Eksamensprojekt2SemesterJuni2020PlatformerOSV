using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.StatePattern
{
    class Attack : IEnemyState
    {
        private Vector2 velocity;

        private float cooldown;

        private float elapsed;

        private Enemy enemy;


        public void Enter(Enemy enemy)
        {
            this.enemy = enemy;
            enemy.MovementSpeed = 200;
            elapsed = 0;

        }

        public void Execute()
        {
            //ChangeState
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
