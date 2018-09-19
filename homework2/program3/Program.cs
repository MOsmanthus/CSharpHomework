using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];
            for (int k = 0; k < 99; k++)
            {
                a[k] = k + 2;
            }//给数组赋值2——100

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 0; j < 99; j++)
                {
                    if (a[j] != 0)
                    {
                        if (a[j] % i == 0 && a[j] / i != 1)
                        { a[j] = 0; }
                    }
                }
            }//筛选出素数，数组素数为本身，非素数为0

            Console.WriteLine("输出2——100之间的所有素数：");
            for (int ii = 0; ii < 99; ii++)
            {
                if (a[ii] != 0)
                {
                    Console.Write(a[ii] + " ");
                }
            }//输出素数
        }
    }
}
