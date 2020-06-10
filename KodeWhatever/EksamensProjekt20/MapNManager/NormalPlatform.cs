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
        public NormalPlatform(Vector2 pos, int blockNumber, bool rotated)
        {
            gamePosition = pos + new Vector2((1000 * blockNumber)+500,0);
            spriteSize = new Vector2(100,40);
            animation.spriteArray = ContentCollection.normalPlatform;
        }
    }
}
