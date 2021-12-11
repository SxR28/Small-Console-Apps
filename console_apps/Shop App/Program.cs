using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static Buyer buyerClass = new Buyer();
        public static string role = "unemployed";
        
        static void Main(string[] args)
        {
            while (true)
            {
                AddItemsInList(buyerClass.ItemsList);
                Console.Clear();
                role = ChooseOption(role);

                if (role == "Exit")
                {
                    Console.WriteLine("We are exiting...");
                    Thread.Sleep(3000);

                    break;
                }

                switch (role)
                {
                    case "Seller": 
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("What do you want to do [ Enter 'Exit' to exit de code ] : \n1. Sell Items \n" +
                                          "2. Remove Item from shop : ");

                            string sellerOption = Console.ReadLine();

                            if (sellerOption == "Exit")
                                break;
                            
                            switch (sellerOption)
                            {
                                case "Sell Items": // SELL ITEMS OPTION
                                    buyerClass.SellItems(buyerClass.ItemsList);
                                    break;
                                
                                /* -------------------------------------------------------------------------------------------------------------------- */
                                
                                case "Remove Item from Shop": // REMOVE ITEMS OPTION
                                    buyerClass.RemoveItems(buyerClass.ItemsList);
                                    break;
                            }
                            

                        }
                        break;
                    case "Buyer":
                        while (true)
                        {
                            Console.Write("What do you want to do [ Enter 'Exit' to exit de code ] : \n1. Buy Items \n" +
                                          "2. Ask for Items" +
                                          "3. Order Items");
                            
                            string buyerOption = Console.ReadLine();

                            if (buyerOption == "Exit")
                                break;

                            switch (buyerOption)
                            {
                                case "Buy Items": // BUY ITEMS OPTION
                                    buyerClass.buyItems(buyerClass.ItemsList);
                                    break;
                                
                                case "Ask for items":
                                    buyerClass.AskForItems();
                                    break;
                                
                                case "Order Items":
                                    buyerClass.OrderItem();
                                    break;
                            }
                        }
                        break;
                    
                    case "Manager":
                        break;
                }
            }

        }

        public static int AddItemsInList(List<string> itemsList)
        {
            Console.WriteLine("How many items do you want to add ? : ");
            int numberOfItemsToAdd = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfItemsToAdd; i++)
            {
                Console.Write($"Insert the {i} item : ");
                string item = Console.ReadLine();
                    
                itemsList.Add(item);
            }
            
            return itemsList.Count;
        }

        public static string ChooseOption(string answer)
        {
            Console.Write("What do you want to be [ Enter 'Exit' to exit de code ] : \n1. Seller \n" +
                          "2. Buyer : ");

            answer = Console.ReadLine();
            return answer;
        }
    }
}