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
using EksamensProjekt20.StatePattern;

namespace EksamensProjekt20.Characters
{
    class Character : GameObject
    {
        protected Thread thread;

        public float currentHealth;
        public float maxHealth;
        protected float healthRegen;
        protected bool alive;
        public int damage;

        protected PrimaryAttack primaryAttack;
        protected int maxAmmo;
        public int ammo;
        protected double attackDelay;
        protected float attackSpeed;

        protected Spell[] spells = new Spell[0];
        
        private List<Buff> buffs = new List<Buff>();
        private List<Buff> buffRemovals = new List<Buff>();
        


        
        public void StartThread()
        {
            alive = true;
            thread = new Thread(ThreadMethod);
            thread.IsBackground = true;
            thread.Start();
        }
        protected void ThreadMethod()
        {
            while(alive) Update(Game1.gameTime);
        }
        public virtual void Attack()
        {
            primaryAttack.Attack();
            attackDelay = attackSpeed;
        }
        
        public virtual void Spell()
        {
            if (spells.Length >= 1)
            {
                spells[0].PrimeSpell(this);
            }
        }
        public virtual void Spell1()
        {
            if (spells.Length >= 2)
            {
                spells[1].PrimeSpell(this);
            }
        }
        public virtual void Spell2()
        {
            if (spells.Length == 3)
            {
                spells[2].PrimeSpell(this);
            }
        }
        public virtual void Death()
        {
            alive = false;
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
