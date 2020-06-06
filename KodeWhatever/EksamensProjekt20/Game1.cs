using EksamensProjekt20.Characters;
using EksamensProjekt20.CommandPattern;
using EksamensProjekt20.MapNManager;
using EksamensProjekt20.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;

//1Master
namespace EksamensProjekt20
{
    /// <summary>
    /// This is the main type for your game. Which lau's pc cant handle
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private InputHandler inputHandler;
        public static Vector2 screenSize;
        private bool fullScreen = false;
        public static GameTime gameTime;
        GameManager gm;
        private int scene;
        Song song;
        private State menuState;

        private bool gameStarted = false;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {

            screenSize = new Vector2(1920,1080);
            ApplyGraphics();
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
            gm = new GameManager();

            inputHandler = new InputHandler();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            menuState = new MenuState(this, graphics.GraphicsDevice, Content);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ContentCollection.LoadContent(Content);
            song = ContentCollection.song;
            MediaPlayer.Play(song);
            MediaPlayer.IsRepeating = true;
            // TODO: use this.Content to load your game content here
        }

        private void MediaPlayer_MediaStateChanged(object sender, EventArgs e)
        {
            MediaPlayer.Volume -= 0.1f;
            MediaPlayer.Play(song);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
            Game1.gameTime = gameTime;
            switch (scene)
            {
                case 0:
                    menuState.Update(gameTime);
                    break;
                case 1:
                    if (gameStarted == false)
                    {
                        gameStarted = true;
                        gm.StartGame();
                    }
                    gm.Update(gameTime);
                    break;
            }
            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
			spriteBatch.Begin();
            switch (scene)
            {
                case 0:
                    menuState.Draw(gameTime, spriteBatch);
                    break;
                case 1:
                    if(gm.currentStage!=null) gm.Draw(spriteBatch);
                    break;
            }
            
            // TODO: Add your drawing code here

            base.Draw(gameTime);
            spriteBatch.End();
        }
        private void ApplyGraphics()
        {
            graphics.PreferredBackBufferWidth = (int)screenSize.X;
            graphics.PreferredBackBufferHeight = (int)screenSize.Y;
            graphics.IsFullScreen = fullScreen;
            graphics.ApplyChanges();
        }
        public void ChangeScene(int newScene)
        {
            scene = newScene;
        }
    }
}
