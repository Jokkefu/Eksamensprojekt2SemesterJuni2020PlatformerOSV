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

namespace EksamensProjekt20.Projectiles
{
    class SwordSlashProjectile : Projectile
    {
        public SwordSlashProjectile(int power, Vector2 origin) : base(power, origin, new Vector2(0,0))
        {
            timed = true;
            duration = 1;
            spriteSize = new Vector2(50, 100);
            animation.spriteArray = ContentCollection.projectile;
            
            gravityOn = false;
        }
        protected override void EnemyHit(Character other)
        {
            other.TakeDamage(damage);
            base.EnemyHit(other);
        }

        protected override void TerrainHit(TerrainPiece other)
        {
            base.TerrainHit(other);
        }
    }
}