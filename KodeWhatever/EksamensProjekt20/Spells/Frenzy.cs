﻿using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class Frenzy : Spell
    {
        public Frenzy()
        {

        }
        public override void Spellcast(Character source)
        {
            source.damage *= 3;
        }
    }
}
