using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.SecondaryAttacks
{
    class SecondaryAttack
    {
        protected Character unit;
        protected int basePower;
        protected float baseSpeed;
        protected Projectile projectile;

        public virtual void Attack()
        {

        }
        public virtual void HoldAttack()
        {

        }

    }
}
