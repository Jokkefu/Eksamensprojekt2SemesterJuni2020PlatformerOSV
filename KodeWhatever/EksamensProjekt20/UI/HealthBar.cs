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
        private Character character;
        private Rectangle containerRect;
        private Rectangle lifebarRect;


        public HealthBar(Character instance)
        {
            character = instance;
            container = ContentCollection.container;
            lifeBar = ContentCollection.lifebar;
        }

        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            lifebarRect = new Rectangle((int)character.screenPosition.X, (int)character.screenPosition.Y + 100, (int)(40 * character.currentHealth / character.maxHealth), 15);
            containerRect = new Rectangle((int)character.screenPosition.X, (int)character.screenPosition.Y + 100, 40, 15);



            spriteBatch.Draw(container, containerRect, Color.White);
            spriteBatch.Draw(lifeBar, lifebarRect, Color.White);
            
        }
    }
}
