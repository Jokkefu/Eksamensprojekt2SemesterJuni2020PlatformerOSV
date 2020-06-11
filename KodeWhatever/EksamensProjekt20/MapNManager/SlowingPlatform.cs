using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using EksamensProjekt20.Buffs;
using EksamensProjekt20.Characters;

namespace EksamensProjekt20.MapNManager
{
    class SlowingPlatform : TerrainPiece
    {
        public SlowingPlatform(Vector2 pos, int blockNumber, bool rotated) : base(pos, blockNumber, rotated)
        {
            animation.spriteArray = ContentCollection.slowingPlatform;
        }
    }
}
