using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;

namespace MonoGame_assignment_1
{
    public class Game1 : Game
    {
        Texture2D backgroundTexture;
        Texture2D treeTexture;
        Texture2D birdTexture;
        Texture2D wormTexture;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            

    }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.ApplyChanges();
            this.Window.Title = "My First MonoGame Assignment";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundTexture = Content.Load<Texture2D>("background");
            treeTexture = Content.Load<Texture2D>("ImageTree");
            birdTexture = Content.Load<Texture2D>("bird");
            wormTexture = Content.Load<Texture2D>("worms");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Pink);
            _spriteBatch.Begin();
            _spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, 800, 500), Color.White);
            _spriteBatch.Draw(treeTexture, new Rectangle(500,100, 200,400 ), Color.White);
            _spriteBatch.Draw(birdTexture, new Rectangle(200, 0, 200, 200), Color.White);
            _spriteBatch.Draw(wormTexture, new Rectangle (280,155, 75, 50),Color.White);

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
