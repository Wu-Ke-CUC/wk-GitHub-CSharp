using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    //静态类不允许实例化  适合当工具类
    static class Tools
    {
        public static int num;
        public static void UseTool()
        {
        }
        public static void Write(int x,int y,string content,ConsoleColor consoleColor=ConsoleColor.Blue)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = consoleColor;
            Console.Write(content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console c = new Console();
            Tools.Write(5, 5, "Hello World");
        }
    }
}
