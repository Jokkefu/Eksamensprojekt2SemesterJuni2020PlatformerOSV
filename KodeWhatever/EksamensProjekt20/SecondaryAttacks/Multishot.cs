﻿using EksamensProjekt20.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.SecondaryAttacks
{
    class Multishot : SecondaryAttack
    {
        public Multishot(Character character)
        {
            unit = character;
        }
        public override void Attack()
        {
            base.Attack();
        }
        public override void HoldAttack()
        {
            base.HoldAttack();
        }


    }
}
