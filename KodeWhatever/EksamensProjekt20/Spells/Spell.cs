using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class Spell
    {
        protected double channelDelay;
        protected float channelDuration;
        protected bool channeling;
        protected Character source;

        public virtual void Spellcast(Character source)
        {
            channelDelay = channelDuration;
            channeling = false;
        }
        public virtual void Update(GameTime gameTime)
        {
            if (channeling)
            {
                if (channelDelay <= 0)
                {
                    Spellcast(source);
                }
                else channelDelay -= gameTime.ElapsedGameTime.TotalSeconds;
            }
        }
        public virtual void PrimeSpell(Character sourceChar)
        {
            source = sourceChar;
            channeling = true;
        }
    }
}
