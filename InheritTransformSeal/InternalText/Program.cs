using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalText
{
    public static class Text1
    {
        internal static int num = 5;
        public static void TextWrite()
        {
            Console.WriteLine($"你调用了TextWrite方法,num为{num}。");
        }
    }
    internal static class Text2
    {
        internal static int num = 5;
        public static void TextWrite()
        {
            Console.WriteLine($"你调用了TextWrite方法,num为{num}。");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
