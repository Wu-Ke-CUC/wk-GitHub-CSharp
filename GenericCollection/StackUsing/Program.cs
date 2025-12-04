using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("ABC");
            stack.Push(false);
            object o = stack.Peek();//返回栈顶元素但不出栈。
            Console.WriteLine(stack.Count);
            object o1 = stack.Pop();//返回栈顶元素并出栈。
            Console.WriteLine(stack.Count);
            object[] objects = stack.ToArray();//转化为数组
            Stack<int> ints = new Stack<int>();//包含特点类型元素的栈
        }
    }
}
