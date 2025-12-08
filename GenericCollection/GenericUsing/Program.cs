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

        class Sington<T> where T :new()//为变量T提供约束，想使用这个类必须，传过来的T必须含有无参构造函数
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
        class Package : Sington<Package>
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
        #region 练习一
        enum EquipEffect
        {
            atk = 0,
            def = 1
        }

        class Equipment
        {
            public string name;
            public int id;
            public EquipEffect effect;
            public int point;
            public Equipment(string name, int id, EquipEffect effect, int point)
            {
                this.name = name;
                this.id = id;
                this.effect = effect;
                this.point = point;
            }
            public override string ToString()
            {
                return $"name:{name} id:{id} effect:{effect} point:{point}";
            }
        }
        class Bag :Sington<Bag>
        {
            List<Equipment> equipments = new List<Equipment>();
            public bool ContainEquipment(int id, out int index)
            {
                for (int i = 0; i < equipments.Count; i++)
                {
                    if (equipments[i].id == id)
                    {
                        index = i;
                        return true;
                    }
                }
                index = 0;
                return false;
            }
            public void AddEquipment(Equipment equipment)
            {
                int index = 0;
                if (ContainEquipment(equipment.id, out index))
                {
                    equipments[index].point += equipment.point;
                    Console.WriteLine($"有{equipment.name}。");
                }
                else
                {
                    equipments.Add(equipment);
                    Console.WriteLine($"没有{equipment.name},已添加。");
                }
            }
            public void RemoveEquipment(int id)
            {
                int index = 0;
                if (ContainEquipment(id, out index))
                {
                    equipments.Remove(equipments[index]);
                    Console.WriteLine("Remove successfully");
                }
                else
                {
                    Console.WriteLine("Remove unsuccessfully");
                }
            }
            public void RemoveEquipment(Equipment equipment)
            {
                RemoveEquipment(equipment.id);
            }
            public void ShowEquipments()
            {
                foreach (var item in equipments)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
        #endregion

        static void Main(string[] args)
        {
            #region
            //TestT(1);
            //TestT(2.2f);
            //TestT("CUC");

            //Person<int> zhangsan = new Person<int>();
            //zhangsan._T = 12;
            //Person<string> lisi = new Person<string>();
            //lisi._T = "Lisi";
            //Student<int> s = new Student<int>();
            //s._T = 12;
            //s._T2 = 24;

            //Package.Instance.Show(2);

            //List<int> list1 = new List<int>();
            //list1.Add(1);
            //list1.Add(2);
            //list1.Add(3);
            //list1.Add(4);
            //int[] ints = new int[4] { 0, 0, 0, 0 };
            //list1.CopyTo(1,ints,1,3);
            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 练习一
            Equipment sword = new Equipment("sword", 10001, EquipEffect.atk, 10);
            Bag.Instance.AddEquipment(sword);
            Equipment sword1 = new Equipment("sword", 10001, EquipEffect.atk, 20);
            Bag.Instance.AddEquipment(sword1);
            Equipment shield = new Equipment("shield", 10002, EquipEffect.def, 10);
            Bag.Instance.AddEquipment(shield);
            Bag.Instance.AddEquipment(sword);
            Bag.Instance.ShowEquipments();
            Bag.Instance.RemoveEquipment(sword);
            Bag.Instance.RemoveEquipment(10001);
            Bag.Instance.ShowEquipments();
            #endregion
        }
        //泛型函数
        static void TestT<T>(T t)
        {
            Console.WriteLine(t);
        }
    }
}
