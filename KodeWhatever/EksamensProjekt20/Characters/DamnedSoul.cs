using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class DamnedSoul : Enemy
    {
        public DamnedSoul(Vector2 position, Vector2 lazyShit) : base(position)
        {
            sprite = SpriteCollection.damnedSoul;
        }
    }
}
