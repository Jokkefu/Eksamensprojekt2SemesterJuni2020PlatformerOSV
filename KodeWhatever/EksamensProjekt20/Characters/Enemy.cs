using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Enemy : Character
    {

        public Enemy(Vector2 position, int block)
        {
            gamePosition = new Vector2(position.X + (block*1000), position.Y);
            spriteSize = new Vector2(20, 50);
        }
    }
}
