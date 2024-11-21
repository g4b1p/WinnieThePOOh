using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Snake : Game
    {
        Random random = new Random();
        Texture2D snakeSheet;
        Rectangle snakeApple = new Rectangle(0, 192, 64, 64);
        List<Part> bodyParts;
        Vector2 snakePosition;
        Vector2 applePosition;
        float snakeSpeed;
        
        public Snake(List<Part> bodyParts)
        {
            this.bodyParts = bodyParts;
        }
        public Vector2 SnakePosition {get { return snakePosition; } set { snakePosition = value; } }
        public Vector2 ApplePosition { get { return applePosition; } set { applePosition = value; } }
        public float SnakeSpeed { get { return snakeSpeed; } set { snakeSpeed = value; } }
        public Texture2D SnakeSheet { get { return snakeSheet; } set { snakeSheet = value; } }

        public void UpdateBody()
        {
            for (int i = bodyParts.Count - 1; i > 0; i--)
            {
                bodyParts[i].Position = bodyParts[i - 1].Position;
            }

            bodyParts[0].Position = snakePosition;
        }

        public void GenerateApplePosition(Random random)
        {
            applePosition = new Vector2(random.Next(0, 10) * 64, random.Next(0, 10) * 64);
        }
        public void DrawApple(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
            snakeSheet,
            applePosition,
            snakeApple,
            Color.White,
            0f,
            new Vector2(0,0),
            Vector2.One,
            SpriteEffects.None,
            0f);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            UpdateBody();
            for (int i = 0; i < bodyParts.Count; i++)
            {
                spriteBatch.Draw(
                snakeSheet,
                bodyParts[i].Position,
                bodyParts[i].Draw(),
                Color.White);
            }
        }
    }
}
