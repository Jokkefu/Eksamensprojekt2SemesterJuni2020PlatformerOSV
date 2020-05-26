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
        protected float channelDuration;
        protected double channelTime;
        protected bool channel = false;
        protected Character source;
        public virtual void Spellcast()
        {
            channelTime = channelDuration;

            channel = false;
        }
        public virtual void Update(GameTime gameTime)
        {
            if (channel)
            {
                if (channelTime <= 0)
                {
                    Spellcast();
                }
                else
                {
                    channelTime -= gameTime.ElapsedGameTime.TotalSeconds;
                }
            }
        }
        public virtual void PrimeAbility(Character source)
        {
            this.source = source;
            channel = true;
        }
    }
}
