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
        private List<Buff> buffs = new List<Buff>();
        private List<Buff> buffRemovals = new List<Buff>();
        public float movementSpeed;
        public float currentHealth;
        public float maxHealth;
        protected float healthRegen;
        protected int maxAmmo;
        public int ammo;
        public int damage;
        protected bool alive;
        protected Thread thread;

        public virtual void StartThread()
        {
            thread = new Thread(ThreadMethod);
            thread.Start();
        }
        protected void ThreadMethod()
        {
            Update(Game1.gameTime);
        }
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
            thread.Abort();
        }
        public override void Update(GameTime gameTime)
        {
            if (currentHealth <= 0)
            {
                Death();
            }
            if ((currentHealth + (healthRegen * gameTime.ElapsedGameTime.TotalSeconds)) >= maxHealth)
            {
                currentHealth = maxHealth;
            }
            else currentHealth += healthRegen * (float)gameTime.ElapsedGameTime.TotalSeconds;
            foreach (Buff buff in buffs)
            {
                buff.Update(gameTime);
            }
            base.Update(gameTime);
            foreach(Buff buff in buffRemovals)
            {
                buffs.Remove(buff);
                
            }
            buffRemovals = new List<Buff>();
            base.Update(gameTime);
        }
        public void AddBuff(Buff buff)
        {
            buffs.Add(buff);
        }
        public void RemoveBuff(Buff buff)
        {
            buffRemovals.Add(buff);
        }

    }
}
