using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add("2", 2);
            hashtable.Add("key", "value");
            hashtable.Add("first", "HuNan");
            Console.WriteLine(hashtable.ContainsKey(1));
            Console.WriteLine(hashtable.ContainsValue("key"));
            hashtable.Remove("2");
            Console.WriteLine(hashtable.ContainsValue(2));
            Console.WriteLine(hashtable["key"]);
            foreach (var item in hashtable.Keys)
            {
                Console.Write(hashtable[item]+" ");
            }
            Console.WriteLine();
            foreach (var item in hashtable.Values)
            {
                Console.Write(item + " ");
            }
        }
    }
}
