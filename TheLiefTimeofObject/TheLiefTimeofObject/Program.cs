using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiefTimeofObject
{
    class Person
    {
        public string name;
        public Person lover;
        public Person() { }
        public Person(string name) { this.name = name; }
        public void FallInLove(Person lover)
        {
            if (this.lover == null && lover.lover == null)
            {
                this.lover = lover;
                lover.lover = this;
            }
        }
        public void ShowLove()
        {
            if (lover != null)
            {
                Console.WriteLine(name + "'s lover is " + lover.name);
            }
        }
        /// <summary>
        /// 析构函数
        /// </summary>
        ~Person()
        {
            Console.WriteLine(name + "被析构了");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("zhangsan");
            Person person1 = new Person("lisi");
            //Console.WriteLine(person.name);
            //person.lover = person1;
            //person1.lover = person;
            person.FallInLove(person1);
            person.ShowLove();
            person = null;//自空
            //Console.WriteLine(person.name);//报空
            GC.Collect();//手动调用内存回收
            person1.ShowLove();
            //person1.lover = null;
            //person1.ShowLove();//报空
            Console.ReadLine();
        }
    }
}