using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EksamensProjekt20.MapNManager
{
    class SlowingPlatform : TerrainPiece
    {
        public SlowingPlatform(Vector2 pos, Vector2 size)
        {
            screenPosition = pos;
            spriteSize = size;
            animation.spriteArray = ContentCollection.slowingPlatform;
        }
    }
}
