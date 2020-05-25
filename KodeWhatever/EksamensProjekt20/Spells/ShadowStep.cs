using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Spells
{
    class ShadowStep : Spell
    {
        public ShadowStep()
        {

        }
        public override void Spellcast(Character source)
        {
            if (Mouse.GetState().X > source.screenPosition.X)
            {
                source.gamePosition.X += 250;
            }
            else
            {
                source.gamePosition.X -= 250;
            }
        }
    }
}
