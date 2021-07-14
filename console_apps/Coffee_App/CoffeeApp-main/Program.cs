using System;

namespace C__Code____M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to StarBucks, this is our new app, in which you can order your coffee home or just in the shop using the Shop Version [DLL.1.01]");
            Console.WriteLine("Keep in mind that in order for the app to work, you will need to include your address , and house number (!)");

            Console.ReadLine();
            Console.Clear(); 

            Console.WriteLine("We have the next menu :"  + "\n " + "- Small Coffee (3 $) \n - Medium Coffee (5 $) \n - Big Coffee (10 $)" + "\n" );
            var OptionCoffee = Option();

            switch (OptionCoffee)
            {
                case "Big": 
                    Console.Clear();
                     Console.WriteLine("You will have to pay 10 dollars, please wait in the waiting bay");
                     Console.ReadLine();
                     break;

                case "Medium":
                     Console.Clear();
                     Console.WriteLine("You will have to pay 5 dollars, please wait in the waiting bay");
                     Console.ReadLine();
                     break;
 
                case "Small":
                     Console.Clear();
                     Console.WriteLine("You will have to pay 3 dollars, please wait in the waiting bay");
                     Console.ReadLine();
                     break;
            }
            static string Option() 
            {
                Console.WriteLine("What Coffee would you like : ");
                return Console.ReadLine();
            }
        }
    }
}
