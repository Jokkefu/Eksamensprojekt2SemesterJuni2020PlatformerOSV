using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Buffs
{
    class Buff : ScreenObject
    {
        protected float efficiency;
        protected double duration;
        protected Character buffTarget;
        protected double toTick;
        protected float tickRate;

        public Buff(float potency, float duration, int ticks, Character target)
        {
            efficiency = potency/ticks;
            this.duration = duration;
            buffTarget = target;
            tickRate = duration / ticks;
        }
        public virtual void ApplyEffect()
        {
            toTick = tickRate;
        }
        public virtual void RemoveEffect()
        {
            buffTarget.RemoveBuff(this);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (sprite != null)
            {
                base.Draw(spriteBatch);
            }
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (duration <= 0)
            {
                RemoveEffect();
            }
            else
            {
                duration -= gameTime.ElapsedGameTime.TotalSeconds;
            }
        }
    }
}
