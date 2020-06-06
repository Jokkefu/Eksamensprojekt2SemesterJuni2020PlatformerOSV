using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Archibald : Enemy
    {
        public Archibald(Vector2 position, int block) : base(position, block)
        {
            animation.spriteArray = ContentCollection.archibald;
            
        }
    }
}
