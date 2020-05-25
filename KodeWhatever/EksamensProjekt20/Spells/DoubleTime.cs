using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class DoubleTime : Spell
    {
        public DoubleTime()
        {

        }
        public override void Spellcast(Character source)
        {
            source.movementSpeed *= 3;
        }
    }
}
