using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EksamensProjekt20.MapNManager
{
    class TriggerPlatform : TerrainPiece
    {
        public TriggerPlatform(Vector2 pos, int blockNumber, bool rotated) : base(pos, blockNumber, rotated)
        {
            exteriorCollision = false;
            animation.spriteArray = ContentCollection.triggerPlatform;
            tag = "TriggerPlatform";
        }

        protected override void OnCollision(GameObject other)
        {
            if(other.tag == "Player")
            {
                GameManager.nextActive = true;
                base.OnCollision(other);
            }
        }
    }
}
