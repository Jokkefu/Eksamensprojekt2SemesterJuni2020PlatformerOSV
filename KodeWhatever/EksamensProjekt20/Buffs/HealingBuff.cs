using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Buffs
{
    class HealingBuff : Buff
    {
        public HealingBuff(float potency, float duration, int tickCount, Character target) : base(potency, duration, tickCount, target)
        {

        }
        public override void ApplyEffect()
        {
            if (buffTarget.currentHealth + efficiency >= buffTarget.maxHealth)
            {
                buffTarget.currentHealth = buffTarget.maxHealth;
            }
            else buffTarget.currentHealth += efficiency;
            base.ApplyEffect();
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            if (toTick <= 0)
            {
                ApplyEffect();
            }
            else
            {
                toTick -= deltaTime;
            }
        }
    }
}
