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
        public List<TerrainPiece> terrainSetup = new List<TerrainPiece>();
        public StageBlock()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(TerrainPiece terrain in terrainSetup)
            {
                terrain.Draw(spriteBatch);
            }
        }
    }
}
