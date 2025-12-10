using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUsing
{
    internal class Program
    {
        public delegate void DelegateTest1();
        static void Test1()
        {
            Console.WriteLine("Test1");
        }
        static void Test2()
        {
            Console.WriteLine("Test2");
        }
        static void Test(DelegateTest1 t)
        {
            t();
        }
        #region
        public delegate void DoThing();
        class Teacher
        {
            public string name;
            public DoThing things;
            public Teacher(string name)
            {
                this.name = name;
            }
            public void RigisterThing(DoThing thing)
            {
                if (things == null)
                {
                    things = new DoThing(thing);
                }
                else
                {
                    things += thing;
                }
            }
            public void Ding()
            {
                things.Invoke();
            }
        }
        class Student
        {
            public string name;
            public string doThing;
            public Student(string name, string doThing)
            {
                this.name = name;
                this.doThing = doThing;
            }
            public void Do()
            {
                Console.WriteLine($"下课了，{name}要{doThing}");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            //声明委托，并将Test1添加到委托
            DelegateTest1 dele = new DelegateTest1(Test1);
            dele.Invoke();//执行委托
            Console.WriteLine("-------");
            //将Test2添加到委托
            dele += Test2;
            dele.Invoke();
            Console.WriteLine("-------");
            //将Test1从委托中去除
            dele -= Test1;
            dele.Invoke();//dele();
            Console.WriteLine("-------");
            //将函数作为参数进行传递,载体就是委托
            Test(Test1);
            Console.WriteLine("-------");
            int[] ints = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 };
            //SortArray(ints);
            SortArray(ints, CompareUpper);
            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SortArray(ints, CompareLower);
            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------");
            Teacher teacher = new Teacher("zhangsan");
            Student student1 = new Student("lisi", "上厕所");
            teacher.RigisterThing(student1.Do);
            Student student2 = new Student("wangwu", "打水");
            teacher.RigisterThing(student2.Do);
            Student student3 = new Student("zhaoliu", "睡觉");
            teacher.RigisterThing(student3.Do);
            teacher.Ding();
        }
        public delegate bool DelegateSort(int num1, int num2);
        static bool CompareUpper(int num1, int num2)
        {
            return num1 > num2;
        }
        static bool CompareLower(int num1, int num2)
        {
            return num1 < num2;
        }
        static void SortArray(int[] ints,DelegateSort compare)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length - i - 1; j++)
                {
                    if (compare(ints[j], ints[j+1]))
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }
        }
    }
}
