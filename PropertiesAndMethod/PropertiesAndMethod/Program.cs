using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethod
{
    class MathTool
    {
        public void Swap(ref int numOne, ref int numTwo)
        {
            int temp = numOne;
            numOne = numTwo;
            numTwo = temp;
        }
        public void Cal(int numOne,int numTwo,out int addResult,out int subResult)
        {
            addResult = numOne + numTwo;
            subResult = numOne - numTwo;
        }
    }
    class Time
    {
        public float deltaTime;
        public float timeScale;
        public float DeltaTime{ get { return new Random().Next(100, 400) / 10000.0f; } }
        public float TimeScale{get;set;}
        public void TScale()
        {
            Console.WriteLine(TimeScale);
            if(TimeScale>1.0f)
            {
                Console.WriteLine("快进");
            }
            else if(Math.Abs(TimeScale-1.0f)<=0.00001f)
            {
                Console.WriteLine("正常");
            }
            else
            {
                Console.WriteLine("减慢");
            }
        }      
    }
    class House
    {
        #region 字段
        private List<Person> hosts;
        private string position;
        private float area;
        private float price;
        #endregion
        #region 属性
        public List<Person> Hosts { get => hosts; set => hosts=value; }
        public string Position { get => position; set => position = value; }
        public float Area { get => area; set => area = value; }
        public float Price { get => price; set => price = value; }
        #endregion
        public float Evaluate()
        {
            return area * price;
        }
        public void Appreciation(float scale)
        {
            price *= (1 + scale);
        }
    }
    class Person
    {
        #region 字段
        private string name;
        private string sex;
        private float money;
        private Person mate;
        private List<House> houses;
        #endregion
        #region 属性
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public float Money { get => money; set => money = value; }
        public Person Mate { get => mate; set => mate = value; }
        public List<House> Houses { get => houses; set => houses = value; }
        #endregion
        public void EarnMoney(float salary)
        {
            if (salary < 0) return;
            money += salary;
            Console.WriteLine(name + "挣了" + salary + "元。");
        }
        public void BuyHouse(House house)
        {
            if (money >= house.Evaluate())
            {
                houses.Add(house);
                money -= house.Evaluate();
                house.Hosts.Clear();
                house.Hosts.Add(this);
            }
            else
            {
                Console.WriteLine("钱不够");
            }
        }
        public void Marry(Person mate)
        {
            if(this.mate==null&&mate.Mate==null)
            {
                this.mate = mate;
                mate.Mate = this;
                foreach(var house in houses)
                {
                    house.Hosts.Add(mate);
                }
                foreach(var house in mate.Houses)
                {
                    house.Hosts.Add(this);
                }
            }
            else
            {
                Console.WriteLine("结婚失败");
            }
        }
        public void SellHouse(House house)
        {
            if(houses.Contains(house))
            {
                houses.Remove(house);
                foreach(var host in house.Hosts)
                {
                    host.Money += house.Evaluate() / house.Hosts.Count;
                }
            }
        }
        public void divorce()
        {
            mate = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region MathTool
            //MathTool ml = new MathTool();
            //int numOne = 10, numTwo = 20;
            #region ref引用参数
            //Console.WriteLine($"Before:{numOne} {numTwo}");
            //ml.Swap(ref numOne, ref numOne);
            ////ref是传递地址，形参与实参都需要加ref
            //Console.WriteLine($"After:{numOne} {numTwo}");
            #endregion
            #region out输出参数
            //int resultOne, resultTwo;
            //ml.Cal(numOne, numTwo, out resultOne, out resultTwo);
            ////out为输出通道，离开方法前必须赋值，形参与实参都需要加out
            //Console.WriteLine($"After:{resultOne} {resultTwo}");
            #endregion
            #endregion 
            #region Time
            //Time time = new Time();
            //Console.WriteLine(time.DeltaTime);
            //time.TimeScale = 1f;
            //time.TScale();
            #endregion
        }
    }
}
