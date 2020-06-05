using EksamensProjekt20.Characters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class Stage
    {
        public static Vector2 stageVector;
        public StartPlatform startPlatform;
        public EndPlatform endPlatform;
        public List<StageBlock> stageSetup = new List<StageBlock>();
        public List<Enemy> enemySetup = new List<Enemy>();
        private Texture2D mapSprite;
        private Rectangle mapRect;
        public Stage(int stageTheme)
        {
            switch (stageTheme)
            {
                case 1:
                    mapSprite = SpriteCollection.background1;
                    break;
                
            }
            stageVector = new Vector2(0, 0);
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            mapRect = new Rectangle((int)stageVector.X, (int)stageVector.X, 7000, 2000);
            //spriteBatch.Draw(mapSprite, mapRect, Color.White);
            foreach(StageBlock block in stageSetup)
            {
                block.Draw(spriteBatch);
            }
        }

    }
}
