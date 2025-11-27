using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    #region 
    class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Greet()
        {
            Console.WriteLine($"Hello,My name is {name},and I'm {age} years old.");
        }
        /// <summary>
        /// 父类中的虚方法
        /// 访问修饰符保持一致，一般为public，protected
        /// </summary>
        public virtual void Work()
        {
            Console.WriteLine($"我是{name}，我的工作是上班。");
        }
    }
    class Student: Person
    {
        public string major;
        public Student(string name,int age,string major): base(name,age)
        {
            this.major = major;
        }

        //对父类方法的重写
        public new void Greet()
        {
            Console.WriteLine($"Hello,My name is {name},I'm {age} years old,and my major is{major}.");
        }

        //对父类方法的覆盖
        public override void Work()
        {
            //base.Work();//调用父类中的Work
            Console.WriteLine($"我叫{name}，是一名学生，工作是学习。");
        }
    }
    #endregion
    #region 练习
    class Animal
    {
        public string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual void Move()
        {
            Console.WriteLine($"{name} is moving.");
        }
    }
    class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine($"{name} is flying.");
        }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine($"{name} is running.");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Person zhangsan = new Student("zhangsan", 18, "C#");
            //普通方法：调用的方法由数据类型决定
            zhangsan.Greet();
            if(zhangsan is Student)
            {
                (zhangsan as Student).Greet();
            }
            //虚方法：调用的方法由内核决定
            zhangsan.Work();
            #endregion
            #region 练习
            List<Animal> animals = new List<Animal>();
            Animal animal = new Animal("animal");
            animals.Add(animal);
            Animal bird = new Bird("bird");
            animals.Add(bird);
            Animal dog = new Dog("dog");
            animals.Add(dog);
            foreach(var item in animals)
            {
                item.Move();
            }
            #endregion
        }
    }
}
