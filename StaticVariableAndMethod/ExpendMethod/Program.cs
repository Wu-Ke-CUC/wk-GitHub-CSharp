using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendMethod
{
    static class Tools
    {
        /// <summary>
        /// string首字母大写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FirstUpper(this string str)
        {
            char[] strs = str.ToCharArray();
            strs[0] = str.ToUpper().ToCharArray()[0];
            return new string(strs);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "student";
            Console.WriteLine(str.FirstUpper());
            str.ToUpper();
        }
    }
}
