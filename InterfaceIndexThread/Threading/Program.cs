using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threading
{
    internal class Program
    {
        static void TestThread()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("TextThread");
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(TestThread);
            thread.Start();
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                if (input == 't')
                {
                    thread.Abort();
                    break;
                }
                else
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
