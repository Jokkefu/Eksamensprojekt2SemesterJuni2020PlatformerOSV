using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Buffs
{
    class SavingGrace : Buff
    {
        public SavingGrace(float potency, float duration, Character target) : base(potency, duration, target)
        {

        }
    }
}
