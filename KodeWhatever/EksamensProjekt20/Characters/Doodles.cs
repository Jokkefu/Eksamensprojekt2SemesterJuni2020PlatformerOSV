using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Doodles : Enemy
    {
        public Doodles(Vector2 position) : base(position)
        {
            sprite = SpriteCollection.damnedSoul;
        }
    }
}
