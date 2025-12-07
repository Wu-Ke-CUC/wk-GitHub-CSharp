using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsing
{
    internal class Program
    {
        /// <summary>
        /// 泛型类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class Person<T>
        {
            public T _T;
        }
        /// <summary>
        /// 泛型类继承
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class Student<T> : Person<T>
        {
            public T _T2;
        }
        //泛型单例类
        interface IShow
        {
            void Show(int n);
        }

        class Sington<T> where T: IShow,new()//为变量T提供约束，想使用这个类必须，传过来的T必须含有无参构造函数
        {
            private static T instance;
            public static T Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                    return instance;
                }
            }
        }
        class Package : Sington<Package>,IShow
        {
            public Package()
            {

            }
            public Package(int n)
            {

            }
            public void Show(int n)
            {
                Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {
            TestT(1);
            TestT(2.2f);
            TestT("CUC");

            Person<int> zhangsan = new Person<int>();
            zhangsan._T = 12;
            Person<string> lisi = new Person<string>();
            lisi._T = "Lisi";
            Student<int> s = new Student<int>();
            s._T = 12;
            s._T2 = 24;

            Package.Instance.Show(2);

            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            int[] ints = new int[4] { 0, 0, 0, 0 };
            list1.CopyTo(1,ints,1,3);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
        //泛型函数
        static void TestT<T>(T t)
        {
            Console.WriteLine(t);
        }
    }
}
