using EksamensProjekt20.Characters;
using EksamensProjekt20.CommandPattern;
using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace EksamensProjekt20.UI
{
    class HealthBar
    {
        private Texture2D container, lifeBar;
        private Enemy character;
        private Rectangle containerRect;
        private Rectangle lifebarRect;


        public HealthBar(Enemy enemyinstance)
        {
            character = enemyinstance;
            container = ContentCollection.container;
            lifeBar = ContentCollection.lifebar;
        }

        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            containerRect = new Rectangle((int)character.screenPosition.X, (int)character.screenPosition.Y + 100, 200, 30);
            lifebarRect = new Rectangle((int)character.screenPosition.X, (int)character.screenPosition.Y + 100, (int)(200 * character.currentHealth / character.maxHealth), 30);
            

            spriteBatch.Draw(container, containerRect, Color.White);
            spriteBatch.Draw(lifeBar, lifebarRect, Color.White);
            
        }
    }
}
