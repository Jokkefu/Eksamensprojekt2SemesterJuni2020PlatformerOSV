using EksamensProjekt20.Characters;
using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20
{
    class ThunderSlamProjectile : Projectile
    {
        private Vector2 knockUp;
        public ThunderSlamProjectile(int power, Vector2 origin) : base(power, origin, new Vector2(0,0))
        {
            timed = true;
            duration = 1;
            knockUp = new Vector2(0, 20);
        }
        protected override void CharacterHit(Character other)
        {
            other.TakeDamage(damage);
            base.CharacterHit(other);
            other.velocity = knockUp;
        }
        protected override void TerrainHit(TerrainPiece other)
        {
            base.TerrainHit(other);
        }

    }
}
