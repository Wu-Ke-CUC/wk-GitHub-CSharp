using System;
using InternalText;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;
            public string sex;
            public float height;
            //private只能在本类中使用
            //protected只能在本类和子类中使用，外部无法访问
            //internal只有当前程序集能使用
            public Person(string name,int age,string sex)
            {
                this.name = name;
                this.age = age;
                this.sex = sex;
            }
            public Person(string name,int age,string sex,float height):this(name,age,sex)
            {
                //节省了重复代码
                this.height = height;
            }
            public void Greet()
            {
                Console.WriteLine("Hello,my name is {0}.and I'm {1} years old.", name, age);
            }
        }
        class Student : Person
        {
            //方法和变量与父类重名使，使用new关键字进行覆盖
            //new public int age;
            public string major;
            public Student(string name, int age, string sex) : base(name, age, sex)
            {
                this.name = name;
                this.age = age;
                this.sex = sex;
            }
            public Student(string name,int age,string sex,string major):this(name,age,sex)
            {
                this.major = major;
            }
            new public void Greet()
            {
                Console.WriteLine("Hello,my name is {0}.I'm {1} years old,and my major is {2}", name, age,major);
            }
            public void Hobby()
            {
                Console.WriteLine($"My name is {name},I like playing basketball.");
            }
        }
        class Programmer : Person
        {
            public Programmer(string name, int age, string sex) : base(name, age, sex)
            {
                this.name = name;
                this.age = age;
                this.sex = sex;
            }
            public void Hobby()
            {
                Console.WriteLine($"My name is {name},I like watching moives.");
            }
        }
        static void Main(string[] args)
        {
            //Student s = new Student("zhangsan", 18, "male");
            //Programmer p = new Programmer("wangwu", 20, "male");
            //s.Greet();
            //p.Greet();
            //s.Hobby();
            //p.Hobby();
            Text1.TextWrite();
            //Text2
            //Console.WriteLine(Text.num);
            //#region 代码块
            //{
            //    int a = 10;
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine(a);
            //增加运行效率
            //#endregion
            Student s = new Student("hhl", 20, "male", "Unity");
            s.Greet();
        }
    }
}
