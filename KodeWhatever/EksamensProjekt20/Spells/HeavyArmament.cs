using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class HeavyArmament : Spell
    {
        public HeavyArmament()
        {

        }
        public override void Spellcast(Character source)
        {
            source.health *= 2;
            source.movementSpeed *= 0.80f; 
        }
    }
}
