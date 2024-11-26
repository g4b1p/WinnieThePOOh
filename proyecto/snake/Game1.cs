using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace snake
{
    public class Game1 : Game
    {
        Random random = new Random();
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
            snake.ApplePosition = new Vector2(random.Next(0, 10) * 64, random.Next(0, 10) * 64);
            snake.DrawApple(_spriteBatch);

            base.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            var kstate = GamePad.GetState(PlayerIndex.One);


            if (kstate.IsButtonDown(Buttons.DPadUp) || kstate.IsButtonDown(Buttons.LeftThumbstickUp))
            {
                direction.Y -= 1;
            }

            if (kstate.IsButtonDown(Buttons.DPadDown) || kstate.IsButtonDown(Buttons.LeftThumbstickDown))
            {
                direction.Y += 1;
            }

            if (kstate.IsButtonDown(Buttons.DPadLeft) || kstate.IsButtonDown(Buttons.LeftThumbstickLeft))
            {
                direction.X -= 1;
            }

            if (kstate.IsButtonDown(Buttons.DPadRight) || kstate.IsButtonDown(Buttons.LeftThumbstickRight))
            {
                direction.X += 1;
            }
            /*           var kstate = Keyboard.GetState();

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
                       */

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            snake.Draw(_spriteBatch);

            if (snake.SnakePosition == snake.ApplePosition)
            {
                snake.DrawApple(_spriteBatch);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
