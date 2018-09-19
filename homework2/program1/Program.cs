using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            Console.WriteLine("Please input an integer:");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.WriteLine("All prime factors of the integer:");
            for(int i=2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                    while (n % i == 0)
                    {
                        n /= i;
                    }
                }
            }
        }
    }
}
