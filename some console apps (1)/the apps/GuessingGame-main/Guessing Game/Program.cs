using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int Chances = 4;

            var RandomNumberHide = new Random().Next(1, 10);
            Console.WriteLine("Your secret number is + {0}", RandomNumberHide);

            for (i = 0; i < 4; i++)
            {
                Console.Write("Guess the Number HUHU : ");
                int NumberGuessing = Convert.ToInt32(Console.ReadLine());

                if (NumberGuessing == RandomNumberHide)
                {
                    Console.WriteLine("YOU WON");
                    break;
                }
                else if (NumberGuessing != RandomNumberHide)
                {
                    int ChancesCalc = Chances = Chances - 1;
                    Console.WriteLine("YOU LOST, you have left " + ChancesCalc + " chances");

                }
                else
                {
                    Console.WriteLine("ERROR // INSERTED SOMETHING WRONG");
                }
            }
            Console.ReadLine();
        }
    }
}
