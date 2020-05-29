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
<<<<<<< HEAD
=======
        public StageBlock(int stageID)
        {
            switch (stageID)
            {
                case 1:
                    terrainSetup.Add(new NormalPlatform(new Vector2(194, 247), new Vector2(382, 459)));
                    terrainSetup.Add(new SlowingPlatform(new Vector2(301, 151), new Vector2(538, 329)));
                    terrainSetup.Add(new FallingPlatform(new Vector2(568, 120), new Vector2(716, 227)));
                    terrainSetup.Add(new TriggerPlatform(new Vector2(116, 492), new Vector2(390, 617)));
                    terrainSetup.Add(new TriggerPlatform(new Vector2(468, 399), new Vector2(894, 509)));
                    terrainSetup.Add(new TriggerPlatform(new Vector2(132, 656), new Vector2(482, 736)));
                    terrainSetup.Add(new TriggerPlatform(new Vector2(148, 762), new Vector2(208, 956)));
                    break;
>>>>>>> 99657528414d3a1f90e3f69333537516fb315705

            }
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
