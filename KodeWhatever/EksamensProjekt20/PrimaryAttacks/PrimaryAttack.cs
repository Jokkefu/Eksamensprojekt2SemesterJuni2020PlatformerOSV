﻿using EksamensProjekt20.Characters;
using EksamensProjekt20.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.PrimaryAttacks
{
    class PrimaryAttack
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
