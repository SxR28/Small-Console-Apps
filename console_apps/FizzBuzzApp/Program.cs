using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("FiZz BuZz");
            Console.ReadLine();
            Console.Clear();
            for (i = 0; i < 100;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZ-BUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine("NO FIZZ AND BUZZ");
                }
            }
            Console.ReadLine();
        }
    }
}
