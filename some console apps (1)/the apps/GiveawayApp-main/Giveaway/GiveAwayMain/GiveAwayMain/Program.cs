using System;

namespace GiveAwayMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the GRAND GIVEAWATY, you have the chances to win a RTX 3090 , a ASUS ROG STRIX, or a SteelSeries Keyboard, to continue, just click...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You have 3 cups, all cups have a gift, choose one wisely (!)");
            Console.ReadLine();
            Console.Write("What is your cup ? : ");
            string ChoosingOption;
            ChoosingOption = Console.ReadLine();
            if (ChoosingOption == "1")
            {
                Console.WriteLine("\n You won a Logitech G503 mouse, BRAVO");
                Console.ReadLine();
                Console.Clear();
            }
            else if (ChoosingOption == "2")
            {
                Console.WriteLine("You won the 3090 CHIEF, YOU ARE COLOSAL !!!!!!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (ChoosingOption == "3")
            {
                Console.WriteLine("You won the STEELSERIES APEX PRO keyboard, YOU ARE THE BEST !!!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("ERROR //  YOU INSERTED SOMETHING WRONG");
            }
        }
    }
}
