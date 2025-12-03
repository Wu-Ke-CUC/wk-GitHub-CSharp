using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListUsing
{
    class Person
    {
        public string name;
        public Person(string name)
        {
            this.name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            int[] ints = new int[4];
            Person person = new Person("zhangsan");
            arrayList.Add(1);
            arrayList.Add(1.5f);
            arrayList.Add(true);
            arrayList.Add(ints);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(person);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);
            arrayList.Remove(ints);
            arrayList.RemoveAt(0);
            Console.WriteLine(arrayList[0]);
            arrayList.Insert(1, "abc");
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);
            arrayList.Clear();
            arrayList.Add(5);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Sort();//快排
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(arrayList.Contains(3));
        }
    }
}
