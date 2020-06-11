using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.States
{
    abstract class State
    {
        protected ContentManager content1;
        protected GraphicsDevice graphicsDevice1;
        protected Game1 game1;
        protected Texture2D menuBackground;

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        public abstract void PostUpdate(GameTime gameTime);

        public State(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
        {
            game1 = game;
            graphicsDevice1 = graphicsDevice;
            content1 = content;
        }

        public abstract void Update(GameTime gameTime);



    }
}
