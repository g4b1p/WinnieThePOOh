using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;
using System.Reflection.Metadata;

namespace snake.States
{
    internal class GameState : State
    {
        Vector2 SnakePosition;
        float snakeSpeed;

        int deadZone;

        private GraphicsDeviceManager _graphics;
        private GraphicsDevice grafikitos;
        private SpriteBatch _spriteBatch;

        Snake snake;
        List<Part> bodyParts = new List<Part>();

        // Score variables
        private int score;

        public int Score { get { return score; } set { score = value; } }
        private SpriteFont font;

        // Singleton instance for GameState
        public static GameState Instance { get; private set; }

        // Propiedad pública para acceder al ContentManager
        public ContentManager ContentManager { get; private set; }

        public GameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager Content, GraphicsDeviceManager deviceManager)
            : base(game, graphicsDevice, Content, deviceManager)
        {
            _game.estado = 1;

            _graphics = deviceManager;
            Content.RootDirectory = "Content";

            // Asigna el ContentManager pasado al constructor a la propiedad pública
            ContentManager = Content;

            snakeSpeed = 200f;
            deadZone = 4096;

            Game1.random = new Random();

            snake.SnakeSheet = Content.Load<Texture2D>("snake_assets");
            // Load font for score
            font = Content.Load<SpriteFont>("File");

            // Initialize score
            score = 0;
            // Set the singleton instance
            Instance = this;

            for (int i = 0; i < 4; i++)
            {
                bodyParts.Add(new Part());
            }
            snake = new Snake(bodyParts);
            // TODO: Add your initialization logic here

            snake.SnakePosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
                                   _graphics.PreferredBackBufferHeight / 2);
            snake.SnakeSpeed = 100f;
            snake.ApplePosition = new Vector2(Game1.random.Next(0, 10) * 64, Game1.random.Next(0, 10) * 64);
            // snake.DrawApple(_spriteBatch);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            snake.Draw(_spriteBatch);

            /*if (snake.SnakePosition == snake.ApplePosition)
			{
				snake.DrawApple(_spriteBatch);
			}*/

            _spriteBatch.End();
        }

        /*private Rectangle GetPlayerBounds()
        {
            float scale = 0.05f; // Escala del 70%
            int hitboxWidth = (int)(playerTexture.Width * scale);
            int hitboxHeight = (int)(playerTexture.Height * scale);
            return new Rectangle(
                (int)(SnakePosition.X - hitboxWidth / 2),
                (int)(SnakePosition.Y - hitboxHeight / 2),
                hitboxWidth,
                hitboxHeight
            );
        }*/

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

            SnakePosition += direction * snakeSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Mantén al jugador dentro de los límites de la pantalla
            /*if (SnakePosition.X > 1500 - playerTexture.Width / 2)
            {
                SnakePosition.X = 1500 - playerTexture.Width / 2;
            }
            else if (SnakePosition.X < playerTexture.Width / 2)
            {
                SnakePosition.X = playerTexture.Width / 2;
            }

            if (SnakePosition.Y > 1035)
            {
                SnakePosition.Y = 1035;
            }
            else if (SnakePosition.Y < playerTexture.Height / 2)
            {
                SnakePosition.Y = playerTexture.Height / 2;
            }*/
        }
    }
}
