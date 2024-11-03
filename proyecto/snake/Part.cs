using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Part : Game
    {
        string type = "bodyR";
        float angle = 0f;
        public float Angle { get { return angle; } set { angle = value; } }
        public string Type {  get { return type;  } set { type = value; } }
        Rectangle snakeBodyRectHorizontal = new Rectangle(64, 0, 64, 64);
        Rectangle snakeBodyRectVertical = new Rectangle(128, 64, 64, 64);
        Rectangle snakeBodyCorner = new Rectangle(0, 0, 64, 64);
        Rectangle snakeHeadVertical = new Rectangle(192, 0, 64, 64);
        Rectangle snakeHeadHorizontal = new Rectangle(256, 0, 64, 64);
        Rectangle snakeTailVertical = new Rectangle(192, 128, 64, 64);
        Rectangle snakeTailHorizontal = new Rectangle(256, 128, 64, 64);

        public Rectangle Draw()
        {
            if (type == "headH")
                return snakeHeadHorizontal;
            else if(type == "headV")
                return snakeHeadVertical;
            else if (type == "bodyRH")
                return snakeBodyRectHorizontal;
            else if (type == "bodyRV")
                return snakeHeadVertical;
            else if (type == "bodyC")
                return snakeBodyCorner;
            else if (type == "tailH")
                return snakeTailHorizontal;
            else 
                return snakeTailVertical;
        }
    }
}