using System;
using InternalText;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

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
            #region Inherit
            //Student s = new Student("zhangsan", 18, "male");
            //Programmer p = new Programmer("wangwu", 20, "male");
            //s.Greet();
            //p.Greet();
            //s.Hobby();
            //p.Hobby();
            //Text1.TextWrite();
            //Text2
            //Console.WriteLine(Text.num);
            #endregion
            #region 代码块
            //{
            //    int a = 10;
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine(a);//报错
            //增加运行效率
            #endregion
            #region 里氏替换
            //子类对象转换为父类
            {
                //Student s = new Student("hhl", 20, "male", "Unity");
                //s.Greet();
                //Person p = s;
                //p.Greet();
                //p.major = "C#";//报错
                //Person lisi = new Student("lisi", 18, "female","C#");
                ////lisi.major = "Unity";//报错
                //Console.WriteLine(((Student)lisi).major);
                //lisi.Greet();
                //((Student)lisi).Greet();//强制类型转换比较危险
            }
            //父类对象无法转换为子类对象
            {
                //Person s = new Person("zhaoliu", 18, "male");
                //Student p = s;//报错
            }
            //is关键词 as关键词
            {
                Person zhangsan = new Student("zhangsan", 18, "male","C#");
                if(zhangsan is Student)
                {
                    Console.WriteLine(((Student)zhangsan).major);
                }
                Student s = zhangsan as Student;//如果不是则返回null 较安全
            }
            #endregion
        }
    }
}
