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
        private List<GameObject> removeList = new List<GameObject>();
        public StageBlock()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(GameObject gO in terrainSetup)
            {
                if (gO.visible)
                {
                    gO.Draw(spriteBatch);
                }
            }
        }
        public void Update(double deltaTime)
        {
            foreach(GameObject gO in terrainSetup)
            {
                if(gO.tag == "Terrain" || gO.tag == "TriggerPlatform")
                {
                    gO.Update(deltaTime);
                }
            }
            foreach(GameObject gO in removeList)
            {
                terrainSetup.Remove(gO);
            }
            removeList = new List<GameObject>();
        }

        public void RemoveObject(GameObject gameObject)
        {
            removeList.Add(gameObject);
        }

    }
}
