using EksamensProjekt20.Characters;
using EksamensProjekt20.PrimaryAttacks;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class Blink : Spell
    {
        
        public Blink()
        {

        }
        public override void Spellcast(Character source)
        {
            if (Mouse.GetState().X >= source.screenPosition.X)
            {
                source.gamePosition.X += 150;
            }
            else
            {
                source.gamePosition.X -= 150;
            }
        }
    }
}
