using System;
using System.Collections.Generic;
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
            public Person(string name,int age,string sex)
            {
                this.name = name;
                this.age = age;
                this.sex = sex;
            }
            public void Greet()
            {
                Console.WriteLine("Hello,my name is {0}.and I'm {1} years old.", name, age);
            }
        }
        class Student : Person
        {
            public Student(string name, int age, string sex): base(name,age,sex)
            {
                this.name = name;
                this.age = age;
                this.sex = sex;
            }
            public void StudentGreet()
            {
                Console.WriteLine($"My name is {name},and I'm {age} years old,I like playing basketball.");
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
            public void ProgrammerGreet()
            {
                Console.WriteLine($"My name is {name},and I'm {age} years old,I like watching moives.");
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("zhangsan",18,"male");
        }
    }
}
