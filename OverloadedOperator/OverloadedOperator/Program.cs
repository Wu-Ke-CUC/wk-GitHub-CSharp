using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOperator
{
    class Vector2
    {
        public int x;
        public int y;
        public Vector2(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 v1,Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }
        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return (v1.x == v2.x && v1.y == v2.y);
        }
        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return !(v1 == v2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2 v1 = new Vector2(1, 2);
            Vector2 v2 = new Vector2(3, 4);
            Vector2 v3 = v1 + v2;
            Console.WriteLine(v3.x + " " + v3.y);
        }
    }
}
