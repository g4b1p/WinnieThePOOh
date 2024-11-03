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
        Texture2D snakeSheet;
        Rectangle snakeApple = new Rectangle(0, 192, 64, 64);
        List<Part> bodyParts;
        Vector2 snakePosition;
        float snakeSpeed;
        
        public Snake(List<Part> bodyParts)
        {
            this.bodyParts = bodyParts;
        }
        public Vector2 SnakePosition {get { return snakePosition; } set { snakePosition = value; } }
        public float SnakeSpeed { get { return snakeSpeed; } set { snakeSpeed = value; } }
        public Texture2D SnakeSheet { get { return snakeSheet; } set { snakeSheet = value; } }

        public void UpdateBody()
        {
            for (int i = 0; i < bodyParts.Count; i++) 
            {
                if (i == 0) 
                    bodyParts[i].Type = bodyParts[i].Type = Part.SnakePartType.HeadHorizontal;
                else if(i < bodyParts.Count - 1)
                    bodyParts[i].Type = bodyParts[i].Type = Part.SnakePartType.BodyHorizontal;
                else
                    bodyParts[i].Type = bodyParts[i].Type = Part.SnakePartType.TailHorizontal;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            UpdateBody();
            int aux = 0;
            for (int i=0; i<bodyParts.Count; i++) 
            {
                spriteBatch.Draw(
                snakeSheet,
                snakePosition,
                bodyParts[i].Draw(),
                Color.White,
                0f,
                new Vector2(aux, 0),
                Vector2.One,
                SpriteEffects.None,
                0f);
                aux += 64;
            }
        }
    }
}
