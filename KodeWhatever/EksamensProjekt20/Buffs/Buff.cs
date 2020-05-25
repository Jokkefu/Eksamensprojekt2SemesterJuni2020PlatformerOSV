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
        public Buff(float potency, float duration)
        {
            efficiency = potency;
            this.duration = duration;
        }
        public virtual void ApplyEffect (Character target)
        {

        }
        
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (sprite != null)
            {
                base.Draw(spriteBatch);
            }
        }
    }
}
