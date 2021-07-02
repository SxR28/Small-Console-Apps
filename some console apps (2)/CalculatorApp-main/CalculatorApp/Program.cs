using System;
using System.Linq;

namespace C__Code_1____M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ThE CaLcUlaToRr ApP");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Enter the first number : ");
            float x = (float)Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Enter the second number : ");
            float y = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now,choose the operation you want to proceed (+ ; - ; * ; / ; average");
            Console.ReadLine();
            Console.Clear();

            Console.Write("What operation you want to proceed ? : ");
            string Option = Console.ReadLine();


            if (Option == "+")
            {
                float Gathering = x + y;

                Console.WriteLine("This is the gather = " + Gathering);
                Console.ReadLine();
            }
            else if (Option == "-")
            {
                float Minus = x - y;

                Console.WriteLine("This is the minus = " + Minus);
                Console.ReadLine();
            }
            else if (Option == "*")
            {
                float Multiply = x * y;

                Console.WriteLine("This is the multiplication = " + Multiply);
                Console.ReadLine();
            }
            else if (Option == "/")
            {
                float Division = x / y;

                Console.WriteLine("This is the division = " + Division);
                Console.ReadLine();
            }
            else if (Option == "Average")
            {
                float Average = (x + y) / 2;

                Console.WriteLine("This is the average = " + Average);
                Console.ReadLine();
            }
        }
    }
}
