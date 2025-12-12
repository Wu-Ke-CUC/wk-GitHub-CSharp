using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    internal class Program
    {
        public delegate void TestGDelegate<T>(T t);
        static void Main(string[] args)
        {
            TestGDelegate<int> testGDegelate = new TestGDelegate<int>(Test1);
            testGDegelate(10);
            //Action
            Action<string, int> action = new Action<string, int>((s, i) =>
            {
                Console.WriteLine(s + i);
            });
            action += TestAction;
            action("I'm ", 18);

            //Func 最后一个泛型类型为返回值类型，前面的为形参，最后一个返回值会覆盖前面的。
            Func<string, int, int> func = new Func<string, int, int>(TestFunc1);
            func += TestFunc2;
            int num = func("abc", 1);
            Console.WriteLine(num);
        }
        static void Test1(int num)
        {
            Console.WriteLine(num);
        }
        static void TestAction(string s, int i)
        {
            Console.WriteLine(s + i);
        }
        static int TestFunc1(string s, int i)
        {
            Console.WriteLine(s);
            return i;
        }
        static int TestFunc2(string s, int i)
        {
            Console.WriteLine(s);
            return i * 2;
        }
    }
}
