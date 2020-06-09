using EksamensProjekt20.Characters;
using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.PrimaryAttacks
{
    class Spit : PrimaryAttack
    {
        public Spit(Character character)
        {
            unit = character;
        }
        public override void Attack()
        {
            if (unit.lookingRight)
            {
                GameManager.AddProjectile(new SpitProjectile(basePower + unit.damage, unit.gamePosition + new Vector2(50, 0)));
            }
            else
            {
                GameManager.AddProjectile(new SpitProjectile(basePower + unit.damage, unit.gamePosition + new Vector2(-50, 0)));
            }
            base.Attack();
        }
    }
}
