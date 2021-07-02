using System;

namespace C__Code____M
{
    class Program
    {
        static void Main(string[] args)
        {
            double DeliveryPrice = 5.99;

            int CoffeePriceBig = 10;
            int CoffeePriceMedium = 5;
            int CoffeePriceSmall = 3;

            double PriceWithDeliveryBig = CoffeePriceBig + DeliveryPrice;
            double PriceWithDeliveryMedium = CoffeePriceMedium + DeliveryPrice;
            double PriceWithDeliverySmall = CoffeePriceSmall + DeliveryPrice;


            Console.WriteLine("Hello, welcome to StarBucks, this is our new app, in which you can order your coffee home or just in the shop using the Shop Version [DLL.1.01]");
            Console.WriteLine("Keep in mind that in order for the app to work, you will need to include your address , and house number (!)");
            Console.WriteLine("We even have a delivery option, it costs 5.99 $");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("We have the next menu :" + "\n " + "- Small Coffee (3 $) \n - Medium Coffee (5 $) \n - Big Coffee (10 $)" + "\n");
            var OptionCoffee = Option();

            switch (OptionCoffee)
            {
                case "Big":
                    Console.Clear();
                    Console.WriteLine("You will have to pay 10 dollars, please wait in the waiting bay, and if your order is with delivery, please type delivery , down in the input");
                    Console.ReadLine();

                    var DeliveryInputBig = Delivery();

                    if (DeliveryInputBig == "Yes")
                    {
                        double BigDeliveryTotal = PriceWithDeliveryBig;
                        Console.WriteLine("You have to pay a total of : " + BigDeliveryTotal + " $");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Wait in the bay");
                        Console.ReadLine();
                    }


                    break;

                case "Medium":
                    Console.Clear();
                    Console.WriteLine("You will have to pay 5 dollars, please wait in the waiting bay, and if your order is with delivery, please type delivery , down in the input");
                    Console.ReadLine();

                    var DeliveryInputMedium = Delivery();

                    if (DeliveryInputMedium == "Yes")
                    {
                        double MediumDeliveryTotal = PriceWithDeliveryMedium;
                        Console.WriteLine("You have to pay a total of : " + MediumDeliveryTotal + " $");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Wait in the bay");
                        Console.ReadLine();
                    }


                    break;

                case "Small":
                    Console.Clear();
                    Console.WriteLine("You will have to pay 3 dollars, please wait in the waiting bay, and if your order is with delivery, please type delivery , down in the input");
                    Console.ReadLine();

                    var DeliveryInputSmall = Delivery();

                    if (DeliveryInputSmall == "Yes")
                    {
                        double SmallDeliveryTotal = PriceWithDeliverySmall;
                        Console.WriteLine("You have to pay a total of : " + SmallDeliveryTotal + " $");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Wait in the bay");
                        Console.ReadLine();
                    }

                    break;
            }
        }
        static string Option()
        {
            Console.WriteLine("What Coffee would you like : ");
            return Console.ReadLine();
        }
        static string Delivery()
        {
            Console.WriteLine("Would you like delivery ? : ");
            return Console.ReadLine();
        }
    }
}
