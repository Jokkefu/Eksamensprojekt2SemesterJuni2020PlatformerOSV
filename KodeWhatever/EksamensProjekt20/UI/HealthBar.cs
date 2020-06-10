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
        private Vector2 position;
        private Enemy character;
        private Rectangle containerRect;
        private Rectangle lifebarRect;


        public HealthBar(Enemy enemyinstance)
        {
            position = new Vector2(100, 100);
            character = enemyinstance;
            container = SpriteCollection.container;
            lifeBar = SpriteCollection.lifebar;
        }

        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            lifebarRect = new Rectangle((int)position.X, (int)position.Y, (int)(200 * character.currentHealth / character.maxHealth), 30);
            containerRect = new Rectangle((int)position.X, (int)position.Y, 200, 30);

            spriteBatch.Draw(lifeBar, lifebarRect, Color.White);
            spriteBatch.Draw(container, containerRect, Color.White);
        }
    }
}
