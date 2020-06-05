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
    class AnimationController : Character
    {
        protected Vector2 mousePos;
        public Texture2D[] spriteArray;
        private Texture2D currentSprite;

        public AnimationController(Texture2D[] warrior[2])
        {
            
        }
        public Texture2D GetSprite()
        {
            return currentSprite;
        }
        public void SetSprite(int spriteIndex)
        {
            currentSprite = spriteArray[spriteIndex];
        }
    }
}
