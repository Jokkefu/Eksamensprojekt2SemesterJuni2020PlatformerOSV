﻿using EksamensProjekt20.Buffs;
using EksamensProjekt20.Characters;
using EksamensProjekt20.PrimaryAttacks;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20
{
    class Projectile : GameObject
    {

        protected int damage;
        protected float speed;

        public Projectile(int power)
        {
            damage = power;
        }
        public void OnHit()
        {

        }

    }
}
