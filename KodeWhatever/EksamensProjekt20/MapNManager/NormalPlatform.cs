using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EksamensProjekt20.MapNManager
{
    class NormalPlatform : TerrainPiece
    {
        public NormalPlatform(Vector2 pos, int blockNumber, bool rotated) : base(pos, blockNumber, rotated)
        {
            animation.spriteArray = ContentCollection.normalPlatform;
        }
    }
}
