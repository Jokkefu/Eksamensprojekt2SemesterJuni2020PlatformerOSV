using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class TacticalDodge : Spell
    {
        public TacticalDodge()
        {

        }
        public override void Spellcast(Character source)
        {
            if (Mouse.GetState().X > source.screenPosition.X)
            {
                source.gamePosition.X += 150;
            }
            else
            {
                source.gamePosition.X -= 150;
            }
            source.ammo = source.maxAmmo;
        }
    }
}
