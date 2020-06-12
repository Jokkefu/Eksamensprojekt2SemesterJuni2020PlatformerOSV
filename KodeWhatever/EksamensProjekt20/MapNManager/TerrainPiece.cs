using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class TerrainPiece : GameObject
    {
        public TerrainPiece(Vector2 pos, int blockNumber, bool flipped)
        {
            gravityOn = false;
            returnValue = pos.Y;
            tag = "Terrain";
            gamePosition = pos + new Vector2((1000 * blockNumber) + 500, 0);
            if (flipped)
            {
                spriteSize = new Vector2(40, 100);
            }
            else spriteSize = new Vector2(100, 40);
        }
    }
}
