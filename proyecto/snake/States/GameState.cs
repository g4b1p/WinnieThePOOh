using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace snake.States
{
    internal class GameState : State
    {
        int gameAux = 0;
        Texture2D snakeTexture;
        Vector2 snakePosition;
        float snakeSpeed;
        Snake snake;
        List<Part> bodyParts = new List<Part>();

        int deadZone;
        Vector2 direction;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Random random;

        // Score variables
        private int score;

        public int Score { get { return score; } set { score = value; } }
        private SpriteFont font;

        // Singleton instance for GameState
        public static GameState Instance { get; private set; }

        // Propiedad pública para acceder al ContentManager
        public ContentManager ContentManager { get; private set; }

        public GameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content, GraphicsDeviceManager deviceManager)
            : base(game, graphicsDevice, content, deviceManager)
        {
            _game.estado = 1;

            _graphics = deviceManager;
            content.RootDirectory = "Content";

            // Asigna el ContentManager pasado al constructor a la propiedad pública
            ContentManager = content;

            snakeSpeed = 400f;
            deadZone = 4096;
            random = new Random();
            // Load font for score
            for (int i = 0; i < 4; i++)
            {
                bodyParts.Add(new Part());
            }
            snake = new Snake(bodyParts);
            // TODO: Add your initialization logic here

            snake.SnakePosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
                                   _graphics.PreferredBackBufferHeight / 2);
            snake.SnakeSpeed = 100f;
            snake.SnakeSheet = content.Load<Texture2D>("snake_assets");
            /*snake.DrawApple(_spriteBatch);*/
            // Set the singleton instance
            Instance = this;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (gameAux == 0)
            {
                snake.GenerateApplePosition(random);
                gameAux = 1;
            }
            spriteBatch.Begin();

            snake.DrawApple(spriteBatch);
            snake.Draw(spriteBatch);
            
            if (snake.SnakePosition == snake.ApplePosition)
                snake.GenerateApplePosition(random);

            spriteBatch.End();
        }


        private Rectangle GetsnakeBounds()
        {
            float scale = 0.05f; // Escala del 70%
            int hitboxWidth = (int)(snakeTexture.Width * scale);
            int hitboxHeight = (int)(snakeTexture.Height * scale);
            return new Rectangle(
                (int)(snakePosition.X - hitboxWidth / 2),
                (int)(snakePosition.Y - hitboxHeight / 2),
                hitboxWidth,
                hitboxHeight
            );
        }

        public override void PostUpdate(GameTime gameTime)
        {
        }

        public override void Update(GameTime gameTime)
        {
            var kstate = Keyboard.GetState();
            Vector2 direction = Vector2.Zero;

            if (kstate.IsKeyDown(Keys.Up) || kstate.IsKeyDown(Keys.W))
            {
                direction.Y -= 1;
            }

            if (kstate.IsKeyDown(Keys.Down) || kstate.IsKeyDown(Keys.S))
            {
                direction.Y += 1;
            }

            if (kstate.IsKeyDown(Keys.Left) || kstate.IsKeyDown(Keys.A))
            {
                direction.X -= 1;
            }

            if (kstate.IsKeyDown(Keys.Right) || kstate.IsKeyDown(Keys.D))
            {
                direction.X += 1;
            }

            if (direction != Vector2.Zero)
            {
                direction.Normalize();
            }

            snakePosition += direction * snakeSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            snake.SnakePosition = snakePosition;


            if (snakePosition.X > 1920 - 128 / 2)
            {
                snakePosition.X = 1920 - 128 / 2;
            }
            else if (snakePosition.X < 128 / 2)
            {
                snakePosition.X = 64 / 2;
            }

            if (snakePosition.Y > 1080)
            {
                snakePosition.Y = 1080;
            }
            else if (snakePosition.Y < 128 / 2)
            {
                snakePosition.Y = 128 / 2;
            }

            snake.UpdateBody();
        }
    }
}
