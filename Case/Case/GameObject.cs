using SnakeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class GameObject
    {
        public Vector2 pos;
        public string icon;
        public ConsoleColor color;
        public GameObject(Vector2 pos, string icon, ConsoleColor color)
        {
            this.pos = pos;
            this.icon = icon;
            this.color = color;
        }
        public GameObject(int x, int y, string icon, ConsoleColor color) : this(new Vector2(x, y), icon, color)
        {
            pos.x = x;
            pos.y = y;
        }
        public void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = color;
            Console.Write(icon);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Remove()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write(" ");
        }
        public void Move(Vector2 dir)
        {
            pos += dir;
        }
    }
}
