using System;

//namespace Variables
//{
//    class Program1
//    {
//        static void Main(string[] args)
//        {
//            int n = 100;
//            int m = 200;
//            int sum = n + m;
//            //m += 100;
//            string name= "result is:";
//            Console.WriteLine(name);
//            Console.WriteLine(sum);
//            Console.ReadKey();
//        }
//    }
//}

//namespace Variables
//{
//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Plase rnter your first number:");
//            string str = Console.ReadLine();
//            //强制类型转化
//            //int result = int.Parse(str) + 20;
//            string result = str + 20.ToString();
//            Console.WriteLine("The result is:");
//            Console.WriteLine(result);
//
//            Console.ReadKey();
//        }
//    }
//}

namespace Variables
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Plase rnter your name:");
            string name = Console.ReadLine();

            Console.Write("Plase rnter your age:");
            string age = Console.ReadLine();

            Console.WriteLine("Your name is " + name + " and your age is " + age + ".");
            Console.ReadKey();
        }
    }
}