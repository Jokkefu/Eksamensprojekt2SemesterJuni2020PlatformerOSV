﻿using EksamensProjekt20.MapNManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Rogue : Player
    {
        public Rogue()
        {
            currentSprite = ContentCollection.hunter;
        }
    }
}
