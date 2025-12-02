using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
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

    internal class Program
    {
        static Vector2 dir = new Vector2(0, 0);
        static void InputDirect()
        {
            while (true)
            {
                //Console.ReadLine();
                //Map.Instance.CrearFood();
                char input = Console.ReadKey(true).KeyChar;
                switch (input)
                {
                    case 'w':
                        if (dir != new Vector2(0, 1))
                        {
                            dir = new Vector2(0, -1);
                        }
                        break;
                    case 'a':
                        if(dir != new Vector2(1, 0))
                        {
                            dir = new Vector2(-1, 0);
                        }                        
                        break;
                    case 's':
                        if (dir != new Vector2(0, -1))
                        {
                            dir = new Vector2(0, 1);
                        }
                        break;
                    case 'd':
                        if (dir != new Vector2(-1, 0))
                        {
                            dir = new Vector2(1, 0);
                        }
                        break;
                    default:
                        break;
                }
                Snake.Instance.Move(dir);
            }
        }
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
            Snake.Instance = new Snake(new GameObject(5, 5, "*", ConsoleColor.Yellow));
            Snake.Instance.Draw();
            Thread inputThread = new Thread(InputDirect);
            inputThread.Start();
            Console.CursorVisible = false;
            while (Snake.Instance.Active)
            {
                Snake.Instance.Remove();
                Snake.Instance.Move(dir);
                Snake.Instance.TriggerEvent();
                Snake.Instance.Draw();
                Thread.Sleep(250);
            }
            inputThread.Abort();
        }
    }
}
