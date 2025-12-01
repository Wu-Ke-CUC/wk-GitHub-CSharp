using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    struct Vector2
    {
        public int x, y;
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x - v2.x, v1.y - v2.y);
        }
        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return ((v1.x == v2.x) && (v1.y == v2.y));
        }
        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return !(v1 == v2);
        }
        public override string ToString()
        {
            return "x:" + x + " y:" + y;
        }
    }
    class GameObject
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

    internal class Program
    {
        static void Main(string[] args)
        {
            //Vector2 v1 = new Vector2(1, 2);
            //Vector2 v2 = new Vector2(3, 4);
            //Console.WriteLine(v1 + v2);
            //GameObject g = new GameObject(new Vector2(3, 3), "*", ConsoleColor.Red);
            //g.Draw();
            //Console.ReadLine();
            //g.Move(new Vector2(1, 1));
            //g.Remove();
            //g.Draw();
            //Map map = new Map("*", new Vector2(10, 5), new Vector2(1, 1), ConsoleColor.Cyan);
            //map.GreateWallDate();
            Map.Instance= new Map("##", new Vector2(10, 10), new Vector2(0, 0), ConsoleColor.Cyan);
            Map.Instance.Draw();
            Console.ReadKey();
        }
    }
}
