using EksamensProjekt20.MapNManager;
using EksamensProjekt20.PrimaryAttacks;
using EksamensProjekt20.SecondaryAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using EksamensProjekt20.UI;

namespace EksamensProjekt20.Characters
{
    class Warrior : Player
    {
        private HealthBar hpBar;
        public Warrior()
        {
            hpBar = new HealthBar(this);
            tag = "Player";
            animation.spriteArray = ContentCollection.warrior;
            spriteSize = new Vector2(40, 90);
            gamePosition = new Vector2(200, 350);
            movementSpeed = 150;
            maxHealth = 100;
            currentHealth = maxHealth;
            healthRegen = 1;
            damage = 10;
            primaryAttack = new SwordSlash(this);
            secondaryAttack = new Rage(this);
            attackSpeed = 1;
            secondaryCD = 10;
            StartThread();
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            hpBar.Draw(spriteBatch);
            base.Draw(spriteBatch);
        }
    }
}
