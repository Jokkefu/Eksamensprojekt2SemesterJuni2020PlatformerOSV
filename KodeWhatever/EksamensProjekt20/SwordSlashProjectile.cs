using EksamensProjekt20.Buffs;
using EksamensProjekt20.Characters;
using EksamensProjekt20.MapNManager;
using EksamensProjekt20.PrimaryAttacks;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20
{
    class SwordSlashProjectile : Projectile
    {
        public SwordSlashProjectile(int power, Vector2 origin) : base(power, origin, new Vector2(0,0))
        {
            timed = true;
            duration = 1;
        }
        public override void OnHit()
        {

            base.OnHit();
        }
    }
}
