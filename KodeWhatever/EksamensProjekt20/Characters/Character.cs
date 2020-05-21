using EksamensProjekt20.PrimaryAttacks;
using EksamensProjekt20.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Character : GameObject
    {
        protected PrimaryAttack primaryAttack;
        protected Spell[] spells = new Spell[0];
        protected List<Item> items = new List<Item>();
        protected List<Buff> buffs = new List<Buff>();
        public float movementSpeed;
        public float health;
        public int ammo;
        public int damage;
        protected Thread thread;

        public void Attack()
        {

        }
        public void SecondaryAttack()
        {

        }
        public void Spell()
        {

        }
        public void Spell1()
        {

        }
        public void Spell2()
        {

        }
        public void Death()
        {

        }

            
    }
}
