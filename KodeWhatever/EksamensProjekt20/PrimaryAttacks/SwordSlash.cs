using EksamensProjekt20.Characters;
using EksamensProjekt20.MapNManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.PrimaryAttacks
{
    class SwordSlash : PrimaryAttack
    {
        public SwordSlash(Character character)
        {
            unit = character;
        }
        public override void Attack()
        {
            GameManager.AddProjectile(projectile = new SwordSlashProjectile(basePower+unit.damage));
            base.Attack();
        }
        public override void HoldAttack()
        {
            base.HoldAttack();
        }
    }
}
