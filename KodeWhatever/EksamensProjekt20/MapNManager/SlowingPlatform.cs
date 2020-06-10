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
        private Player player;
        public SlowingPlatform(Vector2 pos, Vector2 size)
        {
            screenPosition = pos;
            spriteSize = size;
            animation.spriteArray = ContentCollection.slowingPlatform;
            
            if (player.isGrounded == true)
            {
                player.AddBuff(new SpeedBuff(-50, 1, player));
            }
        }
    }
}
