﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.MapNManager;
using EksamensProjekt20.Characters;
using DiagnosticsUtils;

namespace EksamensProjekt20
{
    class ScreenObject
    {
        protected Texture2D currentSprite;
        public Vector2 screenPosition;
        public Vector2 spriteSize;
        public Rectangle spriteRect;
        public bool lookingRight;
        protected AnimationController animation;
        public ScreenObject()
        {
            animation = new AnimationController();
        }

        public virtual void Update(double deltaTime)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteRect = new Rectangle((int)screenPosition.X, (int)screenPosition.Y, (int)spriteSize.X, (int)spriteSize.Y);
            if(spriteRect.Right>0 && spriteRect.Left<Game1.screenSize.X)
            {
                if (spriteRect.Bottom < Game1.screenSize.Y && spriteRect.Top > 0)
                {
                    Texture2D temp = animation.GetSprite();
                    if (temp != null)
                    {
                        spriteBatch.Draw(temp, spriteRect, Color.White);
                    }
                }
            }
        }


        
    }
}
