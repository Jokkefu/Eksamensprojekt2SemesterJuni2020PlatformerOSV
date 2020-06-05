using EksamensProjekt20.MapNManager;
using EksamensProjekt20.PrimaryAttacks;
using EksamensProjekt20.SecondaryAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace EksamensProjekt20.Characters
{
    class Warrior : Player
    {
        public Warrior()
        {
            animation.spriteArray = SpriteCollection.warrior;
            spriteSize = new Vector2(40, 100);
            gamePosition = new Vector2(40, 400);
            movementSpeed = 10f;
            maxHealth = 100;
            currentHealth = maxHealth;
            healthRegen = 1;
            primaryAttack = new SwordSlash(this);
            secondaryAttack = new Rage(this);
            attackSpeed = 1;
            secondaryCD = 10;
            StartThread();
        }

    }
}
