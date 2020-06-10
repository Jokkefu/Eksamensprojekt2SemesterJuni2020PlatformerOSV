using EksamensProjekt20.MapNManager;
using EksamensProjekt20.PrimaryAttacks;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Blob : Enemy
    {
        public Blob(Vector2 position, int block) : base(position, block)
        {
            currentSprite = ContentCollection.blob[0];
            spriteSize = new Vector2(50, 40);
            movementSpeed = 10f;
            maxHealth = 100;
            currentHealth = maxHealth;
            healthRegen = 1;
            primaryAttack = new Spit(this);
            attackSpeed = 1;
        }
    }
}
