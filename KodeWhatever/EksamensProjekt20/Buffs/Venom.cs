﻿using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Buffs
{
    class Venom : Buff
    {
        public Venom(float potency, float duration, int tickCount, Character target) : base(potency, duration, tickCount, target)
        {

        }
    }
}
