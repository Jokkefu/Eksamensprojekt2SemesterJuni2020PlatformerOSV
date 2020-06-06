﻿using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Impastor : Enemy
    {
        public Impastor(Vector2 position, int block) : base(position, block)
        {
            currentSprite = ContentCollection.damnedSoul;
        }
    }
}
