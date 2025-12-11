using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    internal class Program
    {
        public delegate void DelegateTest();
        static void Main(string[] args)
        {
            DelegateTest delegateTest = new DelegateTest(delegate ()
            {
                Console.WriteLine("AnonymousMethod");
            });
            delegateTest();
            //lambda表达式
            DelegateTest delegateTest1 = new DelegateTest(() =>
            {
                Console.WriteLine("AnonymousMethod1");
            });
            delegateTest1();
        }
    }
}
