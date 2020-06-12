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
        protected List<Character> hitUnits = new List<Character>();

        public Projectile(int power, Vector2 origin, Vector2 heading)
        {
            damage = power;
            gamePosition = origin;
            velocity = heading;
        }
        protected override void OnCollision(GameObject other)
        {
            if (other.tag == "Terrain")
            {
                TerrainHit((TerrainPiece)other);
            }
            else if (other.tag == "Enemy")
            {
                bool targetHit = false;
                foreach(Character hit in hitUnits)
                {
                    if(other == hit)
                    {
                        targetHit = true;
                    }
                }
                if (!targetHit)
                {
                    EnemyHit((Character)other);
                }

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
        protected virtual void EnemyHit(Character other)
        {
            hitUnits.Add(other);
        }
    }
}
