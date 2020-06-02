using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Buffs
{
    class HealthBuff : Buff
    {
        public HealthBuff(float potency, float duration, Character target) : base(potency, duration, 1, target)
        {

        }
    }
}
