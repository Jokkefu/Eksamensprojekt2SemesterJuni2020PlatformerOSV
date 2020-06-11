using EksamensProjekt20.Characters;
using EksamensProjekt20.CommandPattern;
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
                if (Game1.gm.playerCharacter.gamePosition.X > enemy.gamePosition.X && Game1.gm.playerCharacter.gamePosition.X < enemy.gamePosition.X + 800)
                {
                    enemy.Jump(new Vector2 (0, -130));
                    velocity = new Vector2(3, 0);
                    enemy.moveVector = velocity;
                }
                if (Game1.gm.playerCharacter.gamePosition.X < enemy.gamePosition.X && Game1.gm.playerCharacter.gamePosition.X > enemy.gamePosition.X - 800)
                {
                    enemy.Jump(new Vector2(0, -130));
                    velocity = new Vector2(-3, 0);   
                    enemy.moveVector = velocity;
                }
            
        }

        public void Exit()
        {

        }
    }
}
