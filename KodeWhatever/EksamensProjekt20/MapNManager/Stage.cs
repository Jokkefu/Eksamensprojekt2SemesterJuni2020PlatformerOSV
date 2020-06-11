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
        public int currentBlock;
        public int previousBlock;
        public StartPlatform startPlatform;
        public EndPlatform endPlatform;
        public List<StageBlock> stageSetup = new List<StageBlock>();
        private Texture2D[] mapSprite = new Texture2D[5];
        private Rectangle[] mapRect = new Rectangle[5];
        public Stage(int stageTheme)
        {
            switch (stageTheme)
            {
                case 1:
                    mapSprite = ContentCollection.background;
                    break;
                
            }
            stageVector = new Vector2(0, 0);
            
        }
        public void Update(Player pc)
        {
            if (pc.gamePosition.X >= 960)
            {
                if (pc.gamePosition.X <= 7500)
                {
                    stageVector = new Vector2(-pc.gamePosition.X + 960, 0);
                }
                else stageVector = new Vector2(-800, 0);
            }
            else stageVector = new Vector2(0, 0);

            int temp = 0;
            if (pc.gamePosition.X >= 500) temp++;
            if (pc.gamePosition.X >= 1500) temp++;
            if (pc.gamePosition.X >= 2500) temp++;
            if (pc.gamePosition.X >= 3500) temp++;
            if (pc.gamePosition.X >= 4500) temp++;
            if (pc.gamePosition.X >= 5500) temp++;
            if (pc.gamePosition.X >= 6500) temp++;
            currentBlock = temp;
            if (previousBlock < currentBlock)
            {
                StartUnits(currentBlock+1);
            }
            previousBlock = currentBlock;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for(int i = currentBlock-1; i<=(currentBlock+1); i++)
            {
                if(i >= 0 && i <= 5)
                {
                    mapRect[i] = new Rectangle((int)stageVector.X + 1000 * i, 0, 1000, (int)Game1.screenSize.Y);
                    spriteBatch.Draw(mapSprite[i], mapRect[i], Color.White);
                }
            }
            
            spriteBatch.DrawString(ContentCollection.font, stageVector.ToString(), new Vector2(10, 90), Color.Black);
            foreach(StageBlock block in stageSetup)
            {
                block.Draw(spriteBatch);
            }
        }
        public void StartUnits(int currentBlock)
        {
            if (currentBlock <= 7)
            {
                foreach (GameObject gO in stageSetup[currentBlock].terrainSetup)
                {
                    if (gO.tag == "Enemy")
                    {
                        Character temp = (Character)gO;
                        temp.StartThread();
                    }
                }
            }
        }
    }
}
