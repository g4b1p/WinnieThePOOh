using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using static segundoIntentoSnake.Part;

namespace segundoIntentoSnake
{
    public class Game1 : Game
    {
        int gameAux = 0;
        Random random = new Random();
        List<Part> bodyParts = new List<Part>();
        Snake snake;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        char direction = ' ';
        float delay = 0.3f;
        float lastDelay = 0f;
        Point position = new Point(10, 10);
        const int cellSize = 32;
        int points = 0;
        SpriteFont spriteFont;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.IsFullScreen = false;
            _graphics.ApplyChanges();
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            bodyParts = new List<Part>();
            for (int i = 0; i < 4; i++)
            {
                bodyParts.Add(new Part()); 
            }
            snake = new Snake(bodyParts);
            snake.SnakePosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
                                   _graphics.PreferredBackBufferHeight / 2);

            if (gameAux == 0)
            {
                snake.GenerateApplePosition(random, _graphics);
                gameAux++;
            }

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            snake.SnakeSheet = Content.Load<Texture2D>("snake_assets");
            spriteFont = Content.Load<SpriteFont>("Fonts/ArcadeFont");
        }

        
        protected override void Update(GameTime gameTime)
        {
            lastDelay += (float)gameTime.ElapsedGameTime.TotalSeconds;

            snake.PartDefinition();


            if (snake.SnakePosition == snake.ApplePosition)
            { 
                snake.mantenerCola = true;

                snake.GenerateApplePosition(random, _graphics);

                Part cola = bodyParts[bodyParts.Count - 1];

                //Part cola = bodyParts[^1];
                //Vector2 posCola = cola.Position;

                //var lastPart = bodyParts[bodyParts.Count - 2];
                var lastPart = bodyParts[^1];

                var newPart = new Part
                {
                    Position = lastPart.Position,
                    Direction = lastPart.Direction
                };

                /*
                if (!mantenerCola)
                {
                    snake.UpdateBody();
                }

                var newPart = new Part
                {
                    Position = bodyParts[^2].Position,
                    Direction = bodyParts[^2].Direction
                };*/

                //snake.PartDefinition();
                //bodyParts.Add(newPart);

                bodyParts.Add(newPart);
                
                delay -= 0.01f;
                points++;

                //snake.UpdateBody();
            }


            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                             Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic 


            var kstate = Keyboard.GetState();

            if (kstate.IsKeyDown(Keys.Up) || kstate.IsKeyDown(Keys.W) && direction != 'D')
            {
                direction = 'U';
            }

            if (kstate.IsKeyDown(Keys.Down) || kstate.IsKeyDown(Keys.S) && direction != 'U')
            {
                direction = 'D';
            }

            if (kstate.IsKeyDown(Keys.Left) || kstate.IsKeyDown(Keys.A) && direction != 'R')
            {
                direction = 'L';
            }

            if (kstate.IsKeyDown(Keys.Right) || kstate.IsKeyDown(Keys.D) && direction != 'L')
            {
                direction = 'R';
            }
                

            if (lastDelay >= delay)
            {
                snake.SnakeDirection = direction;

                if (direction == 'U')
                    position.Y--;
                else if (direction == 'D')
                    position.Y++;
                else if (direction == 'L')
                    position.X--;
                else if (direction == 'R')
                    position.X ++;


                snake.SnakePosition = new Vector2(
                    position.X * cellSize,
                    position.Y * cellSize
                );

                snake.UpdateBody();
                lastDelay = 0f;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            snake.DrawSnake(_spriteBatch);
            snake.DrawApple(_spriteBatch);

            /*
            _spriteBatch.DrawString(spriteFont, $"Manzanas: {points}", new Vector2 (0,0), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
            */

            _spriteBatch.Draw(
                snake.SnakeSheet,
                new Vector2(10, 10),
                snake.apple,
                Color.White,
                0f,
                Vector2.Zero,
                new Vector2(0.5f, 0.5f),
                SpriteEffects.None,
                0f
            );

            _spriteBatch.DrawString(spriteFont, $"{points}", new Vector2(50, 20), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
