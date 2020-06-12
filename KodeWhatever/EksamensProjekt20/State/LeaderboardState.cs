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
using System.Data.SQLite;
using System.Data;

namespace EksamensProjekt20.States
{
    class LeaderboardState : State
    {
        //private Database leaderboard;
        private List<Components> components;
        public LeaderboardState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content/*,Database lBoard*/) : base(game, graphicsDevice, content)
        {
            menuBackground = ContentCollection.menuBackground;
            var buttonTexture = ContentCollection.buttonTexture;
            var buttonFont = ContentCollection.buttonFont;
            lbBackground = ContentCollection.buttonTexture;
            //lBoard = leaderboard;

            var returnButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(1000, 900),
                buttonSize = new Vector2(400, 80),
                Text = "Return",
            };
            returnButton.Click += ReturnButton_Click;


            var leaderBoard = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(50, 100),
                buttonSize = new Vector2(500, 800),
                Text =
                $"High Score:   " +
                "\nRun Nr. 2:   " +
                "\nRun Nr. 3:   " +
                "\nRun Nr. 4:   " +
                "\nRun Nr. 5:   " +
                "\nRun Nr. 6:   " +
                "\nRun Nr. 7:   " +
                "\nRun Nr. 8:   " +
                "\nRun Nr. 9:   " +
                "\nRun Nr. 10:   ",
            };

            components = new List<Components>()
            {
                returnButton,
                leaderBoard,
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
