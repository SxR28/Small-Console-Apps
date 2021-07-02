using System;

namespace Main
{
    class Program // In WORK
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello, this app is an easier alternative for you to choose from our cars, the cars are under this line");
            Console.ReadLine(); */

            // Variables declarations [START] 
            string BmwZ9Car1;
            string BmwX6MCar2;
            string BmwM5Car3;
            string WebSite;
            // ========================
            BmwZ9Car1 = "Bmw Z9";
            BmwX6MCar2 ="Bmw X6 M";
            BmwM5Car3 = "Bmw M5";
            WebSite = "www.Bmw.com";
            // Variables declarations [END] 

           Console.WriteLine("We have 3 car options :" + "\n - " + BmwZ9Car1 + "	\n - " + BmwX6MCar2 + "\n - " + BmwM5Car3 + "\n");
            Console.ReadLine(); 
            Console.WriteLine("Ops.... The site has some administration problems, our Help Desk team and Administrator went to a coffee break, but our IT Tehnicians managed to re-code it and created a little app \n");
            Console.WriteLine("Just insert a number to [1] to [3] and an option will drop out with some information about the car, the options will be dysplay downstairs, click 2 times [!]");
            Console.ReadLine();
            Console.WriteLine("The index of the options are :" + "\n " + "Bmw Z9 = 1" + "\n " + "Bmw X6 M = 2" + "\n " + "Bmw M5 = 3" + "\n");  

            // Option Choosing
            Console.Write(" What is your option  ? " );
            string OptionChoosing;
            OptionChoosing = Console.ReadLine() ;

            // CONDITIONS FUNCTIONS

            if (OptionChoosing == "1")
            {
                Console.WriteLine("\n You made a good choise, the car you choosed was [BMW Z9], a list will pe shown down with car [INFO] \n");
                Console.WriteLine(" [-- Car info --] :  \n  " + "\n Name : (Bmw Z9)" + "\n Type of car : (Sport)" + "\n Number of seats : (4 seats)" + "\n Price : (25.000 New) <--> (10.000 Used or old)" + "\n Place you can buy it : (Bmw Showroom) <--> (Old Car Colection)");
                Console.WriteLine("\n This was the Bmw Z9 , the next car will pe displayed, just press the [RE-BEGIN] option (!) ");
                Console.ReadLine();
                Console.WriteLine("If you want to contiunue, insert [1] in the input for seeing other cars, if you want to stop , insert [0]");
                Console.ReadLine();
                Console.Write("Do you want to continue ? : ");
                string OptionContiunue;
                OptionChoosing = Console.ReadLine();
                if (OptionChoosing == "1")
                {
                    Console.WriteLine("Thank you for choosing to continue with us, if you want to see otherr cars, an input will pe dysplayed a little bit down");
                    Console.Write("What car do yoy want to see ? (2) / (3) : ");
                    string OptionChoosingCarStatement2;
                    OptionChoosingCarStatement2 = Console.ReadLine();
                    if (OptionChoosingCarStatement2 == "2")
                    {
                        Console.WriteLine("\n  You made a very good choise choosing the [BMW X6 M], it is a very safe car and a luxurios too, to see the list press the [INFO] button \n ");
                        Console.WriteLine("[-- Car Info --] : \n " + "\n Name : (Bmw X6 M)" + "\n Type of car : (SUV / SPORT)" + "\n Number of seats : (4) + (2 seats if yoy customize the car)" + "\n Price : (75.000 New) <--> (Depends where you [BUY] it)" + "\n Place you can buy it : (Bmw Showroom) <--> (Car Colection`s) <--> (Diferent people who sell it");
                        Console.WriteLine("\n This the glorios Bmw 6X M, the next car will pe displayed down, hope you liked this one ! ");
                        Console.ReadLine();

                    }
                    else if (OptionChoosingCarStatement2 == "3") 
                    {
                        Console.WriteLine("\n Thank you for choosing our Showroom for Bmw M5, the car is very beautifull, but a little bit expensive. to see the list press the [INFO] button \n ");
                        Console.WriteLine("[-- Car Info --] : \n " + "\n Name : (Bmw M5)" + "\n Type of car : (Sport)" + "\n Number of seats : (4) / (2 depends what car you choose)" + "\n Price : (50.000 New) <--> (20.000-25.000)" + "\n Place you can buy it : (Bmw Showroom) <--> (Car Colection) <--> (Diferent people)");
                        Console.WriteLine("\n This was the sport Bmw M5, the last car from our showroom, to make an appointment to buy the car,visit our site" + "\n \n WebSite : " + WebSite);
                        Console.ReadLine();
                        Console.Write("Don`t worry , we have other cars to show you, the last one is [Bmw X6 M] <--> Would you like to see it ? Type [YES] to the input below and the car wil pop up :)) ");
                        string OptionBmwX6MpopUp;
                        OptionBmwX6MpopUp = Console.ReadLine();
                           if (OptionBmwX6MpopUp == "Yes" && OptionBmwX6MpopUp == "yes")
                        {
                            Console.WriteLine("\n  You made a very good choise choosing the [BMW X6 M], it is a very safe car and a luxurios too, to see the list press the [INFO] button \n ");
                            Console.WriteLine("[-- Car Info --] : \n " + "\n Name : (Bmw X6 M)" + "\n Type of car : (SUV / SPORT)" + "\n Number of seats : (4) + (2 seats if yoy customize the car)" + "\n Price : (75.000 New) <--> (Depends where you [BUY] it)" + "\n Place you can buy it : (Bmw Showroom) <--> (Car Colection`s) <--> (Diferent people who sell it");
                            Console.WriteLine("\n This the glorios Bmw 6X M, the next car will pe displayed down, hope you liked this one ! // Now, click 2 times to exit the Info Program");
                            Console.ReadLine();
                            Console.ReadLine();
                            Console.WriteLine("The [INFO PROGRAM] ended, an only input [WILL POP OUT] to exit the programm, type [Exit] ! Hope to see you back  ");
                            string ExitInput;
                            ExitInput = Console.ReadLine();
                              if (ExitInput == "Exit" && ExitInput == "exit")
                            {
                                Console.WriteLine("Click yes to end");
                                Console.ReadLine();
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Thank you for choosing our Showroom, the option you choosed doesnt`t fit with out DB, please [RE-BEGIN] the proceess -- We hope we helped you");
                    }

                }
                else
                {
                    Console.WriteLine("Thank you for choosing us, we hope we helped you, have a nice day");
                    Console.ReadLine();
                }
            }
            
            else if (OptionChoosing == "2")
            {
                Console.WriteLine("\n  You made a very good choise choosing the [BMW X6 M], it is a very safe car and a luxurios too, to see the list press the [INFO] button \n ");
                Console.WriteLine("[-- Car Info --] : \n " + "\n Name : (Bmw X6 M)" + "\n Type of car : (SUV / SPORT)" + "\n Number of seats : (4) + (2 seats if yoy customize the car)" + "\n Price : (75.000 New) <--> (Depends where you [BUY] it)" + "\n Place you can buy it : (Bmw Showroom) <--> (Car Colection`s) <--> (Diferent people who sell it");
                Console.WriteLine("\n This the glorios Bmw 6X M, the next car will pe displayed down, just press the [RE-BEGIN] option (!) ");
                Console.ReadLine();
            }
            else if (OptionChoosing == "3")
            {
                Console.WriteLine("\n Thank you for choosing our Showroom for Bmw M5, the car is very beautifull, but a little bit expensive. to see the list press the [INFO] button \n ");
                Console.WriteLine("[-- Car Info --] : \n " + "\n Name : (Bmw M5)" + "\n Type of car : (Sport)" + "\n Number of seats : (4) / (2 depends what car you choose)" + "\n Price : (50.000 New) <--> (20.000-25.000)" + "\n Place you can buy it : (Bmw Showroom) <--> (Car Colection) <--> (Diferent people)");
                Console.WriteLine("\n This was the sport Bmw M5, the last car from our showroom, to make an appointment visit our site" + "\n \n WebSite : " + WebSite);
            }
            else
            {
                Console.WriteLine("Error !");
            }
            Console.ReadLine();
        }
    }
}
