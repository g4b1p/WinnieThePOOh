using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace snake
{
    public class Game1 : Game
    {
        Snake snake;
        List<Part> bodyParts = new List<Part>();
        private GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;
        Vector2 direction;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void LoadContent()
        {   
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            snake.SnakeSheet = Content.Load<Texture2D>("snake_assets");
        }
        protected override void Initialize()
        {
            for (int i = 0; i < 4; i++) {
                bodyParts.Add(new Part());
            }
            snake = new Snake(bodyParts);
            // TODO: Add your initialization logic here

            snake.SnakePosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
                                   _graphics.PreferredBackBufferHeight / 2);
            snake.SnakeSpeed = 100f;

            base.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Up))
                direction = new Vector2(0, -1);
            else if (keyboardState.IsKeyDown(Keys.Down))
                direction = new Vector2(0, 1);
            else if (keyboardState.IsKeyDown(Keys.Left))
                direction = new Vector2(-1, 0);
            else if (keyboardState.IsKeyDown(Keys.Right))
                direction = new Vector2(1, 0);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            snake.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
