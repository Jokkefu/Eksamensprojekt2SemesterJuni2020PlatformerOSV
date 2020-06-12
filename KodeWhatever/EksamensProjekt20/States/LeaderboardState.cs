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
        private List<LeaderboardEntry> entries = new List<LeaderboardEntry>();
        public LeaderboardState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content/*,Database lBoard*/) : base(game, graphicsDevice, content)
        {
            menuBackground = ContentCollection.menuBackground;
            var buttonTexture = ContentCollection.buttonTexture;
            var buttonFont = ContentCollection.buttonFont;
            lbBackground = ContentCollection.buttonTexture;
            //lBoard = leaderboard;

            var returnButton = new UIButton(buttonTexture, buttonFont)
            {
                Position = new Vector2(1000, 900),
                buttonSize = new Vector2(400, 80),
                Text = "Return",
            };
            returnButton.Click += ReturnButton_Click;


            var leaderBoard = new UIButton(buttonTexture, buttonFont)
            {
                Position = new Vector2(50, 100),
                buttonSize = new Vector2(500, 800),
                Text = "",
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
            foreach (var component in components) component.Draw(gameTime, spriteBatch);
            
        }

        public override void PostUpdate(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in components) component.Update(gameTime);
            
        }
        private string GetBoardString()
        {
            return $"High Score: {entries[0].kills}, by {entries[0].name} " +
                $"\nRun Nr. 2: {entries[1].kills}, by {entries[1].name} " +
                $"\nRun Nr. 3: {entries[2].kills}, by {entries[2].name}  " +
                $"\nRun Nr. 4: {entries[3].kills}, by {entries[3].name}  " +
                $"\nRun Nr. 5: {entries[4].kills}, by {entries[4].name}  " +
                $"\nRun Nr. 6: {entries[5].kills}, by {entries[5].name}  " +
                $"\nRun Nr. 7: {entries[6].kills}, by {entries[6].name}  " +
                $"\nRun Nr. 8: {entries[7].kills}, by {entries[7].name}  " +
                $"\nRun Nr. 9: {entries[8].kills}, by {entries[8].name}  " +
                $"\nRun Nr. 10: {entries[9].kills}, by {entries[9].name}  ";
        }
    }
}
