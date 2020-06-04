using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.MapNManager
{
    class SpriteCollection
    {
        //Platforms & Stage
        public static Texture2D normalPlatform;
        public static Texture2D slowingPlatform;
        public static Texture2D fallingPlatform;
        public static Texture2D climbablePlatform;
        public static Texture2D triggerPlatform;
        public static Texture2D startPlatform;
        public static Texture2D endPlatform;
        public static Texture2D background1;

        //Character
        public static Texture2D archibald;
        public static Texture2D blob;
        public static Texture2D damnedSoul;
        public static Texture2D doodles;
        public static Texture2D doomer;
        public static Texture2D hunter;
        public static Texture2D impastor;
        public static Texture2D plasmaGhost;
        public static Texture2D rogue;
        public static Texture2D warrior;
        public static Texture2D ziggy;

        //Projectiles
        public static Texture2D arrow;





        public SpriteCollection()
        {

        }
        public static void LoadContent(ContentManager content)
        {
            normalPlatform = content.Load<Texture2D>("normalPlatform");
            slowingPlatform = content.Load<Texture2D>("slowingPlatform");
            fallingPlatform = content.Load<Texture2D>("fallingPlatform");
            climbablePlatform = content.Load<Texture2D>("climbablePlatform");
            triggerPlatform = content.Load<Texture2D>("triggerPlatform");
            startPlatform = content.Load<Texture2D>("startPlatform");
            endPlatform = content.Load<Texture2D>("endPlatform");
            background1 = content.Load<Texture2D>("background1");

            archibald = content.Load<Texture2D>("archibald");
            blob = content.Load<Texture2D>("blob");
            damnedSoul = content.Load<Texture2D>("damnedSoul");
            plasmaGhost = content.Load<Texture2D>("plasmaGhost");
            doodles = content.Load<Texture2D>("doodles");
            doomer = content.Load<Texture2D>("doomer");
            hunter = content.Load<Texture2D>("hunter");
            impastor = content.Load<Texture2D>("impastor");
            rogue = content.Load<Texture2D>("rogue");
            warrior = content.Load<Texture2D>("warrior");
            ziggy = content.Load<Texture2D>("ziggy");

            arrow = content.Load<Texture2D>("arrow");
        }
    }
}
