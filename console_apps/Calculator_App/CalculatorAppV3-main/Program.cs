using System;

namespace C__Code____M
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

            Operations();

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
            else if (Option == "average")
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
                Console.ReadLine();
                Console.WriteLine("You cand do mathematical operations with radicals if you want");
                Console.ReadLine();
                Console.Clear();

                Operations();
                Console.Write("What operation you want to proceed ?");
                string OptionProceedRadical = Console.ReadLine();

                if (OptionProceedRadical == "+")
                {
                    float RadicalGathering = RadicalX + RadicalY;

                    Console.WriteLine("The gathering of X and Y is = " + RadicalGathering);
                    Console.ReadLine();
                }
                else if (OptionProceedRadical == "-")
                {
                    float RadicalMinus = RadicalX - RadicalY;

                    Console.WriteLine("The minus of X and Y is = " + RadicalMinus);
                    Console.ReadLine();
                }
                else if (OptionProceedRadical == "*")
                {
                    float RadicalMultiplication = RadicalX * RadicalY;

                    Console.WriteLine("The multiplication of X and Y is = " + RadicalMultiplication);
                    Console.ReadLine();
                }
                else if (OptionProceedRadical == "/")
                {
                    float RadicalDivision = RadicalX / RadicalY;

                    Console.WriteLine("The divison of X and Y is = " + RadicalDivision);
                    Console.ReadLine();
                }
                else if (OptionProceedRadical == "average")
                {
                    float RadicalAverage = (RadicalX + RadicalY) / 2;

                    Console.WriteLine("The average is = " + RadicalAverage);
                    Console.ReadLine();
                }
            }
        }
        static void Operations()
        {
            Console.WriteLine("Now,choose the operation you want to proceed (+ ; - ; * ; / ; average ; Radical)");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
