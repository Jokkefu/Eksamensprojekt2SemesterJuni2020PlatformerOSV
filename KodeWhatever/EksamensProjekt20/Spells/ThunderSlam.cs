using EksamensProjekt20.Characters;
using EksamensProjekt20.MapNManager;
using EksamensProjekt20.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.Projectiles;

namespace EksamensProjekt20.Spells
{
    class ThunderSlam : Spell
    {
        public ThunderSlam(Character character)
        {
            source = character;
            channelDuration = 0.5f;
        }
        public override void Spellcast()
        {
            if (source.lookingRight)
            {
                GameManager.AddProjectile(new ThunderSlamProjectile(50 + source.damage, source.gamePosition + new Vector2(20, 0)));
            }
            else
            {
                GameManager.AddProjectile(new ThunderSlamProjectile(50 + source.damage, source.gamePosition + new Vector2(-20, 0)));
            }
            base.Spellcast();
        }
    }
}
