using System;
using System.Collections.Generic;

namespace 数组
{
    class Program
    {
        enum Subject
        {
            Chinese,
            //Chinese = 1,
            Math,
            English
        }
        struct Student
        {
            public string name;
            public int age;
            public int id;
            public Student(string name, int age, int id)//自定义构造函数
            {
                this.name = name;
                this.age = age;
                this.id = id;
            }
        }
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
            #region work5实时排序
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
            #region work6打印
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
            //int[,] arr1 = { { 0, 1, 2, 9 }, { 3, 4, 5, 9 }, { 6, 7, 8, 9 } };
            //int[,] arr2 = new int[arr1.GetLength(1), arr1.GetLength(0)];
            //for(int i=0;i<arr1.GetLength(0);i++)
            //{
            //    for(int j=0;j<arr1.GetLength(1);j++)
            //    {
            //        arr2[j, i] = arr1[i, j];
            //    }
            //}
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.Write(arr1[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr2[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region work9枚举使用
            Subject subject = Subject.Chinese;
            if (subject == Subject.English) { }
            switch(subject)
            {
                case Subject.Chinese:
                    break;
                case Subject.Math:
                    break;
                case Subject.English:
                    break;
                default:
                    break;
            }
            //枚举与int的强制转换
            int num = (int)subject;
            //subject = (Subject)3;
            Console.WriteLine(num + " " + (subject + 1));
            //枚举是值类型
            //结构体是值类型
            Student jay = new Student("Jay", 18, 2025);
            #endregion
        }
    }
}
