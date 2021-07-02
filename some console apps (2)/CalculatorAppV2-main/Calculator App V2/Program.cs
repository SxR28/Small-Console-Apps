using System;
using System.Text;
using System.Linq;

namespace C__Code_1____M
{
    class Program
    {
        static void Main(string[] args)
        {
            Writings();

            Console.Write("Enter the first number : ");
            float x = (float)Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Enter the second number : ");
            float y = (float)Convert.ToDouble(Console.ReadLine());

            Choosing();

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
            else if (Option == "Radical")
            {
                float RadicalX = (float)Math.Sqrt(x);
                float RadicalY = (float)Math.Sqrt(y);

                Console.WriteLine("The radical of X is = " + RadicalX);
                Console.WriteLine("The radical of Y is = " + RadicalY);
            }
        }
        static void Writings()
        {
            Console.WriteLine("ThE CaLcUlaToRr ApP");
            Console.ReadLine();
            Console.Clear();

        }
        static void Choosing()
        {
            Console.WriteLine("Now,choose the operation you want to proceed (+ ; - ; * ; / ; average ; Radical");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
