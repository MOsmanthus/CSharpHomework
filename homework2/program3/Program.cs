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
            Console.WriteLine("The prime numbers between 2 and 100:");
            for(int i = 2; i <= 100; i++)
            {
                int n = 0;
                for(int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    n++;
                }
                if (n == i - 2 && i != 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
