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
        SnakePartType type;
        public SnakePartType Type{  get { return type;  } set { type = value; } }
        public enum SnakePartType
        {
            HeadHorizontal,
            HeadVertical,
            BodyHorizontal,
            BodyVertical,
            BodyCorner,
            TailHorizontal,
            TailVertical,
            Apple
        }

        private Dictionary<SnakePartType, Rectangle> snakeParts = new Dictionary<SnakePartType, Rectangle>
{
            { SnakePartType.HeadHorizontal, new Rectangle(256, 0, 64, 64) },
            { SnakePartType.HeadVertical, new Rectangle(192, 0, 64, 64) },
            { SnakePartType.BodyHorizontal, new Rectangle(64, 0, 64, 64) },
            { SnakePartType.BodyVertical, new Rectangle(128, 64, 64, 64) },
            { SnakePartType.BodyCorner, new Rectangle(0, 0, 64, 64) },
            { SnakePartType.TailHorizontal, new Rectangle(256, 128, 64, 64) },
            { SnakePartType.TailVertical, new Rectangle(192, 128, 64, 64) },
            { SnakePartType.Apple, new Rectangle(192, 128, 64, 64) }
        };
        
        public Rectangle Draw()
        {
            if (snakeParts.TryGetValue(type, out Rectangle rectangle))
            {
                return rectangle;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"El tipo {type} no tiene un Rectangle asignado.");
            }
        }
        
    }
}