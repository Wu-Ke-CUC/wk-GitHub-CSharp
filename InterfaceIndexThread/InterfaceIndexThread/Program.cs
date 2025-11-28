using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIndexThread
{
    #region 接口定义
    interface ISpeak
    {
        void Speak();
    }
    interface IMove
    {
        void Move();
    }
    class Animal
    {

    }

    class Person:Animal,ISpeak,IMove//类写在前面
    {
        public string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{name} is walking.");
        }

        public void Speak()
        {
            Console.WriteLine($"{name} is speaking.");
        }
    }
    #endregion
    #region 练习一
    #region interface
    interface IFly
    {
        void Fly();
    }
    interface ISwim
    {
        void Swim();
    }
    #endregion
    class Bird
    {
        public string name;
        public Bird(string name)
        {
            this.name = name;
        }
        public virtual void Move()
        {
            Console.WriteLine($"{name} is moving.");
        }
    }
    class Sparrow : Bird,IFly
    {
        public Sparrow(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{name} is flying");
        }

        public override void Move()
        {
            Console.WriteLine($"{name} is jumping");
        }
    }
    class Ostrich : Bird
    {
        public Ostrich(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{name} is running.");
        }
    }
    class Penguin : Bird,ISwim
    {
        public Penguin(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine($"{name} is walking.");
        }

        public void Swim()
        {
            Console.WriteLine($"{name} is swimming");
        }
    }
    class Helicopter : IFly
    {
        public string name;
        public Helicopter(string name)
        {
            this.name = name;
        }
        public void Fly()
        {
            Console.WriteLine($"{name} is flying");
        }
    }
    #endregion
    #region 练习二 显示实现接口
    interface ICollect
    {
        void CollectHomework();
    }
    interface ICollectSpecial
    {
        void CollectHomework();
    }

    class SchoolPerson
    {
        public string name;
    }
    class Teacher : SchoolPerson,ICollect,ICollectSpecial
    {
        public Teacher(string name)
        {
            this.name = name;
        }

        void ICollectSpecial.CollectHomework()
        {
            Console.WriteLine($"{name}老师收特殊作业。");
        }

        void ICollect.CollectHomework()
        {
            Console.WriteLine($"{name}老师收普通作业。");
        }
    }
    class Student : SchoolPerson,ICollect
    {
        public Student(string name)
        {
            this.name = name;
        }

        public void CollectHomework()
        {
            Console.WriteLine($"{name}学生收作业。");
        }
    }
    class Headmaster : SchoolPerson
    {
        public Headmaster(string name)
        {
            this.name = name;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 练习一
            //IFly bird1 = new Sparrow("sparrow");
            //bird1.Fly();
            //if(bird1 is Sparrow)
            //{
            //    (bird1 as Sparrow).Move();
            //}
            #endregion
            #region 练习二
            SchoolPerson student = new Student("zhangsan");
            SchoolPerson teacher = new Teacher("lisi");
            if (student is ICollect)
            {
                (student as ICollect).CollectHomework();
            }
            if(teacher is ICollect)
            {
                (teacher as ICollect).CollectHomework();
            }
            if (teacher is ICollectSpecial)
            {
                (teacher as ICollectSpecial).CollectHomework();
            }
            #endregion
        }
    }
}
