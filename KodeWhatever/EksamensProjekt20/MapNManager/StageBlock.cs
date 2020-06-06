using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EksamensProjekt20.MapNManager
{
    class StageBlock
    {
        public List<GameObject> terrainSetup = new List<GameObject>();
        public StageBlock()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(GameObject gO in terrainSetup)
            {
                gO.Draw(spriteBatch);
            }
        }
    }
}
