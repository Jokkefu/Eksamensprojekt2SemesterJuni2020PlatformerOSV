using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class DemonSpeed : Spell
    {
        public DemonSpeed()
        {

        }
        public override void Spellcast(Character source)
        {
            if (source.maxHealth <= 1/2)
            {
                source.MovementSpeed *= 1.20f;
            }
        }
    }
}
