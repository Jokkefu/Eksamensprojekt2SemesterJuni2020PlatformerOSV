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
        public ClimbablePlatform(Vector2 pos, int blockNumber, bool rotated) : base(pos, blockNumber, rotated)
        {
            animation.spriteArray = ContentCollection.climbablePlatform;
        }
    }
}
