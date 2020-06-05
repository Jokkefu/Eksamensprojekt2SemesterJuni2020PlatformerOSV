﻿using Microsoft.Xna.Framework.Content;
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
        public static Texture2D[] warrior = new Texture2D[2];
        public static Texture2D ziggy;
        public static Texture2D lifebar;
        public static Texture2D container;

        //Projectiles
        public static Texture2D arrow;





        public SpriteCollection()
        {

        }
        public static void LoadContent(ContentManager content)
        {
            normalPlatform = content.Load<Texture2D>("platform texture 1");
            slowingPlatform = content.Load<Texture2D>("platform texture 2");
            fallingPlatform = content.Load<Texture2D>("platform texture 3");
            climbablePlatform = content.Load<Texture2D>("platform texture 4");
            triggerPlatform = content.Load<Texture2D>("platform texture 5");
            startPlatform = content.Load<Texture2D>("platform texture 6");
            endPlatform = content.Load<Texture2D>("platform texture 6");
            //background1 = content.Load<Texture2D>("background1");

            //archibald = content.Load<Texture2D>("archibald");
            //blob = content.Load<Texture2D>("blob");
            //damnedSoul = content.Load<Texture2D>("damnedSoul");
            //plasmaGhost = content.Load<Texture2D>("plasmaGhost");
            //doodles = content.Load<Texture2D>("doodles");
            //doomer = content.Load<Texture2D>("doomer");
            //hunter = content.Load<Texture2D>("hunter");
            //impastor = content.Load<Texture2D>("impastor");
            //rogue = content.Load<Texture2D>("rogue");
            //ziggy = content.Load<Texture2D>("ziggy");
            lifebar = content.Load<Texture2D>("healthBar");
            container = content.Load<Texture2D>("healthGauge");


            //arrow = content.Load<Texture2D>("arrow");

            #region WarriorArray
            warrior[0] = content.Load<Texture2D>("warrior");//Venstre
            warrior[1] = content.Load<Texture2D>("warrior1");//Højre
            #endregion

            
        }
    }
}
