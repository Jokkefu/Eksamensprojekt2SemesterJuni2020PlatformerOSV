using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EksamensProjekt20
{
    class AnimationController
    {
        public Texture2D[] spriteArray = new Texture2D[0];
        private Texture2D currentSprite;

        public AnimationController()
        {
            
        }
        public Texture2D GetSprite()
        {
            if (currentSprite == null)
            {
                if (spriteArray.Length >= 1)
                {
                    currentSprite = spriteArray[0];
                }
                else currentSprite = null;
            }
            return currentSprite;
        }
        public void SetSprite(int spriteIndex)
        {
            currentSprite = spriteArray[spriteIndex];
        }
        public void Walking(bool walkingRight)
        {
            if (!walkingRight)
            {
                currentSprite = spriteArray[0];
            }
            else
            {
                currentSprite = spriteArray[1];
            }
        }

    }
}
