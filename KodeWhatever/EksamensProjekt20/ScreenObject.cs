using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.MapNManager;
using EksamensProjekt20.Characters;

namespace EksamensProjekt20
{
    class ScreenObject
    {
        protected Texture2D sprite;
        protected Vector2 screenPosition;
        protected Vector2 spriteSize;
        public Rectangle spriteRect;
        public bool lookingRight;
        protected AnimationController animation;
        public ScreenObject()
        {
            animation = new AnimationController();
            
        }

        public virtual void Update(GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteRect = new Rectangle((int)screenPosition.X, (int)screenPosition.Y, (int)spriteSize.X, (int)spriteSize.Y);
            if(spriteRect.Right>0 && spriteRect.Left<Game1.screenSize.X)
            {
                if (spriteRect.Bottom < Game1.screenSize.Y && spriteRect.Top > 0)
                {
                    spriteBatch.Draw(sprite, spriteRect, Color.White);
                }
            }
        }


        
    }
}
