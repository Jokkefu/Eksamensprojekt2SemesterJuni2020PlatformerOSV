using EksamensProjekt20.MapNManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.Characters
{
    class Hunter : Player
    {
        public Hunter()
        {
            currentSprite = ContentCollection.hunter;
            movementSpeed = 10;
        }
    }
}
