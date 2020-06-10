using EksamensProjekt20.MapNManager;
using EksamensProjekt20.PrimaryAttacks;
using EksamensProjekt20.SecondaryAttacks;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Archibald : Enemy
    {
        public Archibald(Vector2 position, int block) : base(position, block)
        {
            animation.spriteArray = ContentCollection.archibald;
            spriteSize = new Vector2(40, 100);
            movementSpeed = 100f;
            maxHealth = 150;
            currentHealth = maxHealth;
            healthRegen = 1;
            primaryAttack = new Swipe(this);
            attackSpeed = 2;
            
        }
    }
}
