using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class Spell
    {
        public double channelDelay;
        protected float channelDuration;
        protected bool channeling;
        protected Character source;

        public virtual void Spellcast()
        {
            channeling = false;
        }
        public virtual void Update(GameTime gameTime)
        {
            if (channeling)
            {
                if (channelDelay <= 0)
                {
                    Spellcast();
                }
                else channelDelay -= gameTime.ElapsedGameTime.TotalSeconds;
            }
        }
        public virtual void PrimeSpell(Character sourceChar)
        {
            channelDelay = channelDuration;
            source = sourceChar;
            channeling = true;
        }
    }
}
