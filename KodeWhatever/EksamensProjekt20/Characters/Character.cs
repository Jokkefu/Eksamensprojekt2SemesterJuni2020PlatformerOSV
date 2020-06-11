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
using DiagnosticsUtils;
using EksamensProjekt20.MapNManager;

namespace EksamensProjekt20.Characters
{
    class Character : GameObject
    {
        protected Thread thread;
        protected ExecutionStopwatch stopwatch = new ExecutionStopwatch();
        protected double deltaTime;

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
            thread = new Thread(ThreadMethod)
            {
                IsBackground = true
            };
            thread.Start();

        }

        protected void ThreadMethod()
        {
            while(alive)
            {
                stopwatch.Start();
                Update(deltaTime);
                stopwatch.Stop();
                deltaTime = stopwatch.Elapsed.TotalSeconds*8f;
            }
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
        public override void Update(double deltaTime)
        {
            if (currentHealth <= 0)
            {
                Death();
            }
            if ((currentHealth + (healthRegen * deltaTime)) >= maxHealth)
            {
                currentHealth = maxHealth;
            }
            else currentHealth += (float)(healthRegen * deltaTime);
            foreach (Buff buff in buffs)
            {
                buff.Update(deltaTime);
            }
            foreach(Buff buff in buffRemovals)
            {
                buffs.Remove(buff);
            }
            buffRemovals = new List<Buff>();
            if (attackDelay > 0) attackDelay -= deltaTime;
            if (gamePosition.Y >= Game1.screenSize.Y + 20) OutOfBounds();
            base.Update(deltaTime);
        }
        public void AddBuff(Buff buff)
        {
            buffs.Add(buff);
        }
        public void RemoveBuff(Buff buff)
        {
            buffRemovals.Add(buff);
        }
        public void TakeDamage(float damageTaken)
        {
            currentHealth -= damageTaken;
        }
        public void Jump(Vector2 velocity)
        {
            if (isGrounded)
            {
                this.velocity.Y = velocity.Y;
                isGrounded = false;
            }
        }

        public void OutOfBounds()
        {
            gamePosition.Y = -10;
            TakeDamage(10);
        }
    }
}
