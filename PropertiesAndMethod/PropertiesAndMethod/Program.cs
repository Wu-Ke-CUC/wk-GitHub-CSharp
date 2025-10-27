using System;
using System.Collections.Generic;
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
