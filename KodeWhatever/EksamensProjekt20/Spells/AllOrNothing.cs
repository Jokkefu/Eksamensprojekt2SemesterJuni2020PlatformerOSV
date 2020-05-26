using EksamensProjekt20.Buffs;
using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class StandYourGround : Spell
    {
        public StandYourGround()
        {
            
        }
        public override void Spellcast()
        {
            source.buffs.Add(new DamageBuffScale());
            source.buffs.Add(new HealthBuff());
            source.buffs.Add(new Snare());
        }
        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
