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
        public Person() { }
        public Person(string name) { this.name = name; }
        /// <summary>
        /// 析构函数
        /// </summary>
        ~Person() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
