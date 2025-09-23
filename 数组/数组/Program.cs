using System;
using System.Collections.Generic;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>names=new List<string>();
            //string[] names = new string[3];
            names.Add("zhangsan");
            names.Add("lisi");
            names.Add("wangwu");
            int n = 0;
            for(int i=0;i<names.Count;i++)
            {
                if (names[i]=="zhangsan")
                {
                   n++;
                }
                Console.WriteLine(names[i]);
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
