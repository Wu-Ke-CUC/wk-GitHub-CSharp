using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    #region
    abstract class Person
    {
        public abstract void Greet();//不能有函数体
        public virtual void Work()
        {

        }
    }
    class Student : Person
    {
        //子类必须实现抽象类的所有抽象方法
        public override void Greet()
        {
            Console.WriteLine("Hello");
            //throw new NotImplementedException();
        }
        public override void Work()
        {
            //base.Work();
        }
    }
    #endregion
    #region Graphics
    abstract class Graphics
    {
        public abstract float Perimeter();
        public abstract float Square();
    }
    class Rectangle : Graphics
    {
        public float width, height;
        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public override float Perimeter()
        {
            return 2 * (width + height);
        }

        public override float Square()
        {
            return width * height;
        }
    }
    class Circle : Graphics
    {
        public float r;
        public Circle(int r)
        {
            this.r = r;
        }

        public override float Perimeter()
        {
            return 2 * 3.14f * r;
        }

        public override float Square()
        {
            return 3.14f * r * r ;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Person person = new Person();//无法实例
            Person person = new Student();
            person.Greet();
            #endregion
            #region
            List<Graphics> graphics = new List<Graphics>();
            Graphics rect = new Rectangle(3, 4);
            graphics.Add(rect);
            Graphics circle = new Circle(5);
            graphics.Add(circle);
            foreach (var item in graphics)
            {
                Console.WriteLine(item.Perimeter());
                Console.WriteLine(item.Square());
            }
            #endregion
        }
    }
}
