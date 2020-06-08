using EksamensProjekt20.Controls;
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
    public class MenuState : State
    {
        private List<Components> components;

        public MenuState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            var buttonTexture = content1.Load<Texture2D>("Controls/Knap");
            var buttonFont = content1.Load<SpriteFont>("Fonts/Font");

            var newGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(700, 150),
                Text = "New Game",
            };

            newGameButton.Click += NewGameButton_Click;

            var LoadGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(700, 400),
                Text = "Load Game",
            };

            LoadGameButton.Click += LoadGameButton_Click;

            var QuitGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(700, 650),
                Text = "Quit Game",
            };

            QuitGameButton.Click += QuitGameButton_Click;

            components = new List<Components>()
            {
                newGameButton,
                LoadGameButton,
                QuitGameButton,
            };


        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            game1.Exit();
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            game1.ChangeScene(1);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (var component in components)
                component.Draw(gameTime, spriteBatch);

            
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
