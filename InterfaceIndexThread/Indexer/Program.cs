using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Person
    {
        public string name;
        public string sex;
        public int age;
        public Person(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        //索引器
        public string this[int x]
        {
            get
            {
                switch (x)
                {
                    case 0:return name;
                    case 1:return sex;
                    case 2: return age.ToString();
                    default: return "数据异常";
                }
            }
            set
            {
                switch (x)
                {
                    case 0: name = value;break;
                    case 1: sex= value;break;
                    case 2: age = int.Parse(value);break;
                    default:break;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("zhangsan", "male", 18);
            Console.WriteLine(person[0]);
            person[2] = "20";
            Console.WriteLine(person.age);
        }
    }
}
