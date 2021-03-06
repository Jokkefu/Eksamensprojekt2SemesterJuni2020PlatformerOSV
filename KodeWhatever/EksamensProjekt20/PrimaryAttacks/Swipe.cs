﻿using EksamensProjekt20.Characters;
using EksamensProjekt20.MapNManager;
using EksamensProjekt20.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.Projectiles;

namespace EksamensProjekt20.PrimaryAttacks
{
    class Swipe : PrimaryAttack
    {
        public Swipe(Character character)
        {
            unit = character;
        }
        public override void Attack()
        {
            if (unit.lookingRight)
            {
                GameManager.AddProjectile(new SwipeProjectile(basePower + unit.damage, unit.gamePosition + new Vector2(5, 0)));
            }
            else
            {
                GameManager.AddProjectile(new SwipeProjectile(basePower + unit.damage, unit.gamePosition + new Vector2(-5, 0)));
            }
            base.Attack();
        }

    }
}
