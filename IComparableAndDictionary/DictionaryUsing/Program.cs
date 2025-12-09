using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students1 = new Dictionary<int, string>();
            students1.Add(10001, "zhangsan");
            students1.Add(10002, "lisi");
            students1.Add(10003, "wangwu");
            if (students1.ContainsKey(10001))
            {
                Console.WriteLine(students1[10001]);
            }
            foreach (var item in students1.Values)
            {
                Console.WriteLine(item);
            }
            string name;
            if (students1.TryGetValue(10001, out name))
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Null");
            }
            //<id,<name,score>> //将键值对数据类型作为值
            Dictionary<int, KeyValuePair<string, int>> students2 = new Dictionary<int, KeyValuePair<string, int>>();
            KeyValuePair<string, int> s1 = new KeyValuePair<string, int>("zhangsan", 100);
            KeyValuePair<string, int> s2 = new KeyValuePair<string, int>("lisi", 90);
            KeyValuePair<string, int> s3 = new KeyValuePair<string, int>("wangwu", 95);
            students2.Add(10001,s1);
            students2.Add(10002,s2);
            students2.Add(10003,s3);
            foreach (var item in students2.Keys)
            {
                Console.WriteLine($"id:{item} name:{students2[item].Key} score:{students2[item].Value}");
            }
        }
    }
}
