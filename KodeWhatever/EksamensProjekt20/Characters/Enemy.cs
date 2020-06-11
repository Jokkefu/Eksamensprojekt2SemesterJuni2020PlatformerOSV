using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.StatePattern;
using EksamensProjekt20.MapNManager;
using DiagnosticsUtils;
using EksamensProjekt20.Buffs;
using EksamensProjekt20.UI;
using Microsoft.Xna.Framework.Graphics;

namespace EksamensProjekt20.Characters
{
    class Enemy : Character
    {
        private IEnemyState currentState;
        private HealthBar healthBar;

        public Enemy(Vector2 position, int block)        
        {
            gamePosition = new Vector2(position.X + (block*1000) + 500, position.Y);
            spriteSize = new Vector2(20, 50);
            ChangeState(new Idle());
            healthBar = new HealthBar(this);
        }
        public override void Update(double deltaTime)
        {
            base.Update(deltaTime);
            currentState.Execute(deltaTime);
            ChangeStateTrigger(deltaTime);
        }
        //Triggers the enemy to be Aggressive or idle depending on the following conditions
        public void ChangeStateTrigger(double deltaTime)
        {
            //Aggro range
            if (Game1.gm.playerCharacter.gamePosition.X > this.gamePosition.X && Game1.gm.playerCharacter.gamePosition.X < this.gamePosition.X + 700 || Game1.gm.playerCharacter.gamePosition.X < this.gamePosition.X && Game1.gm.playerCharacter.gamePosition.X > this.gamePosition.X - 700)
            {
                ChangeState(new Attack());
            }
        }
        public void ChangeState(IEnemyState newEnemyState)
        {
            currentState = newEnemyState;
            currentState.Enter(this);
        }
        public override void Death()
        {
            GameManager.AddKill(this);
            base.Death();

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            healthBar.Draw(spriteBatch);
        }
    }
}
