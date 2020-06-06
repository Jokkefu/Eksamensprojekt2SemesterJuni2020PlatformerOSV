using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class ContentCollection
    {
        //Platforms & Stage
        public static Texture2D[] normalPlatform = new Texture2D[1];
        public static Texture2D[] slowingPlatform = new Texture2D[1];
        public static Texture2D[] fallingPlatform = new Texture2D[1];
        public static Texture2D[] climbablePlatform = new Texture2D[1];
        public static Texture2D[] triggerPlatform = new Texture2D[1];
        public static Texture2D[] startPlatform = new Texture2D[1];
        public static Texture2D[] endPlatform = new Texture2D[1];
        public static Texture2D background1;

        //Character
        public static Texture2D[] archibald = new Texture2D[1];
        public static Texture2D blob;
        public static Texture2D damnedSoul;
        public static Texture2D doodles;
        public static Texture2D doomer;
        public static Texture2D hunter;
        public static Texture2D impastor;
        public static Texture2D plasmaGhost;
        public static Texture2D rogue;
        public static Texture2D[] warrior = new Texture2D[2];
        public static Texture2D ziggy;

        //Projectiles
        public static Texture2D arrow;

        //Sound
        public static Song song;

        //Fonts
        public static SpriteFont font;

        public ContentCollection()
        {

        }
        public static void LoadContent(ContentManager content)
        {
            normalPlatform[0] = content.Load<Texture2D>("platform texture 1");
            slowingPlatform[0] = content.Load<Texture2D>("platform texture 2");
            fallingPlatform[0] = content.Load<Texture2D>("platform texture 3");
            climbablePlatform[0] = content.Load<Texture2D>("platform texture 4");
            triggerPlatform[0] = content.Load<Texture2D>("platform texture 5");
            startPlatform[0] = content.Load<Texture2D>("platform texture 6");
            endPlatform[0] = content.Load<Texture2D>("platform texture 6");
            //background1 = content.Load<Texture2D>("background1");
            
            archibald[0] = content.Load<Texture2D>("archibald");
            /*
            blob = content.Load<Texture2D>("blob");
            damnedSoul = content.Load<Texture2D>("damnedSoul");
            plasmaGhost = content.Load<Texture2D>("plasmaGhost");
            doodles = content.Load<Texture2D>("doodles");
            doomer = content.Load<Texture2D>("doomer");
            hunter = content.Load<Texture2D>("hunter");
            impastor = content.Load<Texture2D>("impastor");
            rogue = content.Load<Texture2D>("rogue");
            ziggy = content.Load<Texture2D>("ziggy");


            arrow = content.Load<Texture2D>("arrow");
            */

            #region WarriorArray
            warrior[0] = content.Load<Texture2D>("Warrior");//Venstre
            warrior[1] = content.Load<Texture2D>("Warrior1");//Højre
            #endregion

            song = content.Load<Song>("Fight_mp3");

            font = content.Load<SpriteFont>("font");
        }
    }
}
