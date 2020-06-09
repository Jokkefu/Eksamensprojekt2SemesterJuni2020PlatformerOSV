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
    class Projectile : GameObject
    {
        protected double duration;
        protected bool timed;
        protected int damage;
        protected float speed;

        public Projectile(int power, Vector2 origin, Vector2 heading)
        {
            damage = power;
            gamePosition = origin;
            velocity = heading;
        }
        public virtual void OnHit(GameObject other)
        {
            if (other.tag == "Terrain")
            {
                TerrainHit((TerrainPiece)other);
            }
            else if (other.tag == "Character")
            {
                CharacterHit((Character)other);
            }
        }
        protected void EndProjectile()
        {
            GameManager.RemoveProjectile(this);
        }
        public override void Update(double deltaTime)
        {
            if (timed)
            {
                if (duration <= 0)
                {
                    EndProjectile();
                }
                else duration -= deltaTime;
            }

            base.Update(deltaTime);
        }
        protected virtual void TerrainHit(TerrainPiece other)
        {

        }
        protected virtual void CharacterHit(Character other)
        {

        }
    }
}
