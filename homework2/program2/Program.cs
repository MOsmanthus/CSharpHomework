using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, a = 0;
            int[] numbers = new int[12] { 6, 9, 8, 10, 33, 67, 85, 96, 2, 4, 15, 24 };
            Array.Sort(numbers);
            Console.WriteLine("The Maximum: " + numbers[11]);
            Console.WriteLine("The Minimum: " + numbers[0]);
            foreach(int i in numbers)
            {
                m += i;
            }
            a = m / numbers.Length;
            Console.WriteLine("The Sum: " + m);
            Console.WriteLine("The Average: " + a);
        }
    }
}
