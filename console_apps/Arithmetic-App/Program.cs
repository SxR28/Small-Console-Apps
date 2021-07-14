using System;

namespace Arithmetic_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            // int g = 0;

            /* Console.WriteLine("Hey, probably uou want an arithmethic media calculator, you came into the right place");
            Console.ReadLine();
            Console.WriteLine("In order to work , you will complete some inputs, and from that inputs, the program will work");
            Console.ReadLine();
            Console.Clear(); */

            Console.Write("Insert your length : ");
            int ParseLength = Convert.ToInt32(Console.ReadLine());

            int[] Numbers = new int[ParseLength];

            for (i = 0; i < ParseLength; i++)
            {
                Console.Write("Insert the numbers : ");
                Numbers[i] = Convert.ToInt32(Console.ReadLine());

                for (j = 0; j < 1; j++)
                {
                    Console.WriteLine(" The number  was saved to DB (!)");
                }
                Console.Clear();
            }

            for (k = 0; k < ParseLength; k++)
            {
                Console.WriteLine("The numbers are " + Numbers[k]);
            }

            Console.WriteLine("====================================");

            int sum = 0;
            for (int h = 0; h < Numbers.Length; h++)
            {
                sum += Numbers[h];
            }

            Console.WriteLine("The aritmethics are " + (double)sum / Numbers.Length);

            Console.ReadLine();
        }
    }
}
