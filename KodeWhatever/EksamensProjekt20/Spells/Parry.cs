using EksamensProjekt20.Buffs;
using EksamensProjekt20.Characters;
using EksamensProjekt20.MapNManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class Parry : Spell
    {
        public Parry(Character character)
        {
            source = character;
            channelDuration = 0.1f;
        }
        public override void Spellcast()
        {
            source.AddBuff(new DamageReduction(10000, 4, source));
        }
    }
}
