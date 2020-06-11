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

        private Enemy enemy;

        double currenttime = Game1.gameTime.ElapsedGameTime.TotalSeconds;
        double turntime = 0;
        bool timetoturn = false;

        public void Enter(Enemy enemy)
        {
            this.enemy = enemy;
            //velocity = new Vector2(0.001f, 0);

        }

        public void Execute(double deltatime)
        {

            currenttime += deltatime;

            if (currenttime > turntime)
            {
                if (timetoturn == true)
                {
                    velocity = new Vector2 (0.5f, 0);
                    turntime = currenttime + 20;
                    enemy.moveVector = velocity;
                    timetoturn = false;
                }
                else if (timetoturn == false)
                {
                    velocity = new Vector2 (-0.5f, 0);
                    turntime = currenttime + 20;
                    enemy.moveVector = velocity;
                    timetoturn = true;
                }
            }
        }

        public void Exit()
        {
            
        }
    }
}
