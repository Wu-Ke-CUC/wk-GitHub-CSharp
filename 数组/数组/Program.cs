using System;
using System.Collections.Generic;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region work1
            //List<string>names=new List<string>();
            ////string[] names = new string[3];
            //names.Add("zhangsan");
            //names.Add("lisi");
            //names.Add("wangwu");
            //int n = 0;
            //for(int i=0;i<names.Count;i++)
            //{
            //    if (names[i]=="zhangsan")
            //    {
            //       n++;
            //    }
            //    Console.WriteLine(names[i]);
            //}
            //Console.WriteLine(n);
            //Console.ReadKey();
            #endregion
            #region work2
            //for (int i = 100; i < 1000; i++)
            //{
            //    List<int> nums = new List<int>();
            //    int sum = 0;
            //    int temp = i;
            //    while (temp != 0)
            //    {
            //        nums.Add(temp % 10);
            //        temp /= 10;
            //    }
            //    foreach (var n in nums)
            //    {
            //        sum += n;
            //    }
            //    if (sum == 7) Console.WriteLine(i);
            //}
            #endregion
            #region work3
            //int sum = 0;
            //int num = 1;
            //do
            //{
            //    sum += num;
            //    num++;
            //} while (sum + num < 10000);
            //Console.WriteLine("sum最小值为：" + sum + " 项数是：" + num);
            #endregion
            #region work4
            //int[] a = new int[3] { 10, 20, 30 };
            //int[] b = a;
            //b[0] = 20;
            //Console.WriteLine(a[0]);
            #endregion
            #region work5
            //int[] nums = new int[5];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("请输入第" + (i + 1) + "个元素:");
            //    int currentNum = int.Parse(Console.ReadLine());
            //    nums[i] = currentNum;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (currentNum < nums[j])
            //        {
            //            for (int k = i - 1; k >= j; k--)
            //            {
            //                nums[k + 1] = nums[k];
            //            }
            //            nums[j] = currentNum;
            //            break;
            //        }
            //    }
            //    foreach (int n in nums)
            //    {
            //        Console.Write(n + " ");
            //    }
            //    Console.WriteLine();
            //}
            ////foreach (int n in nums)
            ////{
            ////    Console.Write(n + " ");
            ////}
            #endregion
            #region work6
            //int input = int.Parse(Console.ReadLine());
            //for(int i=0;i<2*input-1;i++)
            //{
            //    for(int j=0;j<2*input-1;j++)
            //    {
            //        if(j + i == input - 1 || j - i == input - 1 || i + j == 3 * input - 3 || i - j == input - 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region work7冒泡排序
            //int[] arr = { 8, 7, 0, 2, 4, 1, 6 };
            ////int[] arr = { 0, 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool hasSort = false;
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            hasSort = true;
            //            int temp = arr[j + 1];
            //            arr[j + 1] = arr[j];
            //            arr[j] = temp;
            //        }
            //        foreach (int n in arr)
            //        {
            //            Console.Write(n + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    if (!hasSort) break;
            //}
            #endregion
            #region work8二维数组

            #endregion
        }
    }
}
