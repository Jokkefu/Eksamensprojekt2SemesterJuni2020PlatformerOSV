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

        private Enemy enemy;

        public void Enter(Enemy enemy)
        {
            this.enemy = enemy;
            //velocity = new Vector2(0.001f, 0);

        }

        public void Execute(double deltatime)
        {
                if ( true == true)
                {
                    velocity = new Vector2(0.5f, 0);
                    enemy.moveVector = velocity;
                }/*
                if ()
                {
                    velocity = new Vector2(-0.5f, 0);
                    turntime = currenttime + 20;
                    enemy.moveVector = velocity;
                    timetoturn = true;
                }*/
            
        }

        public void Exit()
        {

        }
    }
}
