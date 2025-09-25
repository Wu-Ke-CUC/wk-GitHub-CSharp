using System;
namespace Temperature
{
    class Work8
    {
        static void Main()
        {
            double fahrenheit=double.Parse(Console.ReadLine());
            double centigrade=(fahrenheit-32)/1.8;
            Console.WriteLine($"摄氏温度是：{centigrade}");
        }
    }
}