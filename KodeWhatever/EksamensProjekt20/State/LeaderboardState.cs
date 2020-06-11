using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.Controls;
using EksamensProjekt20.MapNManager;

namespace EksamensProjekt20.States
{
    class LeaderboardState : State
    {
        private List<Components> components;
        public LeaderboardState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            menuBackground = ContentCollection.menuBackground;
            var buttonTexture = ContentCollection.buttonTexture;
            var buttonFont = ContentCollection.buttonFont;

            var returnButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(1700, 900),
                Text = "Return",
            };

            returnButton.Click += ReturnButton_Click;

            components = new List<Components>()
            {
                returnButton,
            };
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            game1.ChangeScene(0);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(menuBackground, new Rectangle(0, 0, 1920, 1080), Color.White);
            foreach (var component in components)
                component.Draw(gameTime, spriteBatch);
        }

        public override void PostUpdate(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in components)
                component.Update(gameTime);
        }
    }
}
