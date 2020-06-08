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
        public virtual void OnHit()
        {
            
        }
        protected void EndProjectile()
        {
            GameManager.RemoveProjectile(this);
        }
        public override void Update(GameTime gameTime)
        {
            if (timed)
            {
                if (duration <= 0)
                {
                    EndProjectile();
                }
                else duration -= gameTime.ElapsedGameTime.TotalSeconds;
            }

            base.Update(gameTime);
        }
    }
}
