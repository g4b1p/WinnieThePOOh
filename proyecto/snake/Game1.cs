using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using snake.States;
namespace snake
{
    public class Game1 : Game
    {
        public int estado;
        private GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;
        private State _currentState;
        private State _nextState;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            if (GraphicsDevice == null)
            {
                _graphics.ApplyChanges();
            }

            // Change the resolution to match your current desktop
            _graphics.PreferredBackBufferWidth = GraphicsDevice.Adapter.CurrentDisplayMode.Width;
            _graphics.PreferredBackBufferHeight = GraphicsDevice.Adapter.CurrentDisplayMode.Height;
            _graphics.ApplyChanges();
            _graphics.IsFullScreen = true;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        public void ChangeState(State state)
        {
            _nextState = state;
        }
        public ContentManager ContentManager { get; private set; }
        protected override void LoadContent()
        {   
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _currentState = new GameState(this, _graphics.GraphicsDevice, Content, _graphics);
            // TODO: use this.Content to load your game content here

        }
        protected override void Initialize()
        {
            IsMouseVisible = true;

            base.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (_nextState != null)
            {
                _currentState = _nextState;
                _nextState = null;
            }

            _currentState.Update(gameTime);
            _currentState.PostUpdate(gameTime);
            // TODO: Add your update logic here


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _currentState.Draw(gameTime, _spriteBatch);
            // TODO: Add your drawing code here
            _spriteBatch.Begin();


            /*if (snake.SnakePosition == snake.ApplePosition)
            {
                snake.DrawApple(_spriteBatch);
            }*/

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
