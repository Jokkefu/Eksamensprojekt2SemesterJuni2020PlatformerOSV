using EksamensProjekt20.PrimaryAttacks;
using EksamensProjekt20.Spells;
using EksamensProjekt20.Buffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace EksamensProjekt20.Characters
{
    class Character : GameObject
    {
        protected PrimaryAttack primaryAttack;
        protected Spell[] spells = new Spell[0];
        //protected List<Item> items = new List<Item>();
        public List<Buff> buffs = new List<Buff>();
        public float movementSpeed;
        public float health;
        public int ammo;
        public int damage;
        protected Thread thread;
        public int maxAmmo;

        public virtual void Attack()
        {

        }
        
        public virtual void Spell()
        {

        }
        public virtual void Spell1()
        {

        }
        public virtual void Spell2()
        {

        }
        public virtual void Death()
        {

        }
        public override void Update(GameTime gameTime)
        {
            foreach(Buff buff in buffs)
            {
                buff.Update(this, gameTime);
            }
            base.Update(gameTime);
        }

    }
}
