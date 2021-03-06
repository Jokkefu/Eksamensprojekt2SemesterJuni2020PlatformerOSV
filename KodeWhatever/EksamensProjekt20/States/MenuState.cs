﻿using EksamensProjekt20.Controls;
using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt20.States
{
    class MenuState : State
    {
        private List<Components> components;
        private Texture2D titleSprite;
        
        public MenuState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            menuBackground = ContentCollection.menuBackground;
            var buttonTexture = ContentCollection.buttonTexture;
            var buttonFont = ContentCollection.buttonFont;

            var newGameButton = new UIButton(buttonTexture, buttonFont)
            {
                Position = new Vector2(760, 500),
                buttonSize = new Vector2(400, 80),
                Text = "New Game",
            };

            newGameButton.Click += NewGameButton_Click;

            var leaderboardButton = new UIButton(buttonTexture, buttonFont)
            {
                Position = new Vector2(760, 600),
                buttonSize = new Vector2(400, 80),
                Text = "Leaderboard",
            };

            leaderboardButton.Click += LeaderboardButton_Click;

            var quitGameButton = new UIButton(buttonTexture, buttonFont)
            {
                Position = new Vector2(760, 700),
                buttonSize = new Vector2(400, 80),
                Text = "Quit Game",
            };

            quitGameButton.Click += QuitGameButton_Click;

            components = new List<Components>()
            {
                newGameButton,
                leaderboardButton,
                quitGameButton,
            };
            titleSprite = ContentCollection.titleSprite;
            


        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            game1.Exit();
        }

        private void LeaderboardButton_Click(object sender, EventArgs e)
        {
            game1.ChangeScene(2);
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            game1.ChangeScene(1);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(menuBackground, new Rectangle(0, 0, 1920, 1080), Color.White);
            spriteBatch.Draw(titleSprite, new Rectangle(560, 200, 800, 200), Color.White);
            foreach (var component in components) component.Draw(gameTime, spriteBatch);
            
            
        }
        public override void PostUpdate(GameTime gameTime)
        {
            //Removing Sprites if not needed
        }
        public override void Update(GameTime gameTime)
        {
            foreach (var component in components)
                component.Update(gameTime);
        }

    }
}
