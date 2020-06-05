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
    class Enemy : Character
    {
        protected HealthBar healthbar;
        public Enemy(Vector2 position)
        {
            screenPosition = position;
            spriteSize = new Vector2(20, 50);
            healthbar = new HealthBar(this);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            healthbar.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            healthbar.Draw(spriteBatch);
            base.Draw(spriteBatch);
        }
    }
}
