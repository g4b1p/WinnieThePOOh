using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace snake
{
    public class Game1 : Game
    {
        Snake snake;
        float snakeX;
        float snakeY;
        List<Part> bodyParts = new List<Part>();
        private GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;
        KeyboardState oldState;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void LoadContent()
        {   
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            oldState = Keyboard.GetState();

            // TODO: use this.Content to load your game content here
            snake.SnakeSheet = Content.Load<Texture2D>("snake_assets");
        }
        protected override void Initialize()
        {
            
            for (int i = 0; i < 4; i++) {
                bodyParts.Add(new Part());
            }
            snake = new Snake(bodyParts);
            snakeX = snake.SnakePosition.X;
            snakeY = snake.SnakePosition.Y;
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
            UpdateInput();
            base.Update(gameTime);
        }

        private void UpdateInput()
        {
            KeyboardState oldState = Keyboard.GetState();
            KeyboardState newState = Keyboard.GetState();

            // Is the Right key down?
            if (newState.IsKeyDown(Keys.Right))
            {
                if (!oldState.IsKeyDown(Keys.Left))
                {
                    snakeX++;
                }
            }
            else if (newState.IsKeyDown(Keys.Left))
            {
                if (!oldState.IsKeyDown(Keys.Right))
                {
                    snakeX--;
                }
            }
            else if (newState.IsKeyDown(Keys.Up))
            {
                if (!oldState.IsKeyDown(Keys.Down))
                {
                    snakeY++;
                }
            }
            else if (newState.IsKeyDown(Keys.Down))
            {
                if (!oldState.IsKeyDown(Keys.Up))
                {
                    snakeY--;
                }
            }
            // Update saved state.
            
            oldState = newState;
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
