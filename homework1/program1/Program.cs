using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int m = 0;
            int n = 0;
            Console.WriteLine("Please input an int : ");
            s = Console.ReadLine();
            m = int.Parse(s);
            Console.WriteLine("Please input another int : ");
            s = Console.ReadLine();
            n = int.Parse(s);
            Console.WriteLine("Product of the two numbers is : " + (m * n));
        }
    }
}
