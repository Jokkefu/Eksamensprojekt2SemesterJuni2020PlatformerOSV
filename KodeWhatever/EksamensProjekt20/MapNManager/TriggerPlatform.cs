﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EksamensProjekt20.MapNManager
{
    class TriggerPlatform : TerrainPiece
    {
        public TriggerPlatform(Vector2 pos, int block)
        {
            screenPosition = pos;
            spriteSize = new Vector2(100, 40);
            animation.spriteArray = ContentCollection.triggerPlatform;
        }
    }
}
