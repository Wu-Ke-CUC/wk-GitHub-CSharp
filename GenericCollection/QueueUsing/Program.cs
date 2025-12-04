using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("ABC");
            queue.Enqueue(false);
            object o = queue.Dequeue();//返回队首元素并出队。
            object[] objects = queue.ToArray();
            Console.WriteLine(queue.Count);
        }
    }
}
