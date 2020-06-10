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
        public List<Enemy> enemySetup = new List<Enemy>();
        private Texture2D mapSprite;
        private Rectangle mapRect;
        public Stage(int stageTheme)
        {
            switch (stageTheme)
            {
                case 1:
                    mapSprite = ContentCollection.background1;
                    break;
                
            }
            stageVector = new Vector2(0, 0);
            StartUnits(0);
        }
        public void Update(Player pc)
        {
            stageVector = new Vector2(-pc.gamePosition.X + (Game1.screenSize.X/2), 0);
            int temp = 0;
            if (stageVector.X >= 1000) temp++;
            if (stageVector.X >= 2000) temp++;
            if (stageVector.X >= 3000) temp++;
            if (stageVector.X >= 4000) temp++;
            if (stageVector.X >= 5000) temp++;
            if (stageVector.X >= 6000) temp++;
            if (stageVector.X >= 7000) temp++;
            currentBlock = temp;
            if (previousBlock < currentBlock)
            {
                StartUnits(currentBlock);
            }
            previousBlock = currentBlock;
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
        private void StartUnits(int currentBlock)
        {
            foreach (GameObject gO in stageSetup[currentBlock].terrainSetup)
            {
                if (gO.tag == "Character")
                {
                    Character temp = (Character)gO;
                    temp.StartThread();
                }
            }
        }
    }
}
