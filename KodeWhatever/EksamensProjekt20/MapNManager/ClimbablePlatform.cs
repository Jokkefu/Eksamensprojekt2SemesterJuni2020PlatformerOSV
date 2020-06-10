using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class ClimbablePlatform : TerrainPiece
    {
        public ClimbablePlatform(Vector2 pos, Vector2 size)
        {
            screenPosition = pos;
            spriteSize = size;
            animation.spriteArray = ContentCollection.climbablePlatform;
        }
    }
}
