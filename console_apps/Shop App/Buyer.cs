using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    public class Buyer : Basket
    {
        public decimal wallet = 0;

        public void AddMoneyInWallet(decimal wallet)
        {
            Console.Write("How much money do you want to add ? : ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (TypeCheck(amount))
                wallet = amount;
        }
        
        /* ------------------------------------------------------------------------ */
        public void buyItems(List<string> listToBuy)
        {
           Console.WriteLine("How many items do you want to buy ? : ");
           int numberOfItemsToBuy = Int32.Parse(Console.ReadLine());

           if (TypeCheck(numberOfItemsToBuy))
           {
               for (int i = 0; i < numberOfItemsToBuy; i++)
               {
                   Console.WriteLine("What item do you want to buy ? : ");
                   string itemToBuy = Console.ReadLine();

                   if (VerifyItemAvailability(ItemsList, itemToBuy))
                   {
                       Console.Clear();
                       Console.WriteLine($"You bought {itemToBuy} for 50 $");
                       ItemsList.Remove(itemToBuy);
                       Console.ReadLine();
                   }
                   else
                   {
                       Console.Clear();
                       Console.WriteLine("There isn't such item");
                       Console.ReadLine();
                   }
               }
           }
        }
        
        public void AskForItems()
        { 
            Console.Write("Insert the item name : ");
            string itemName = Console.ReadLine();
               
            if(TypeCheck(itemName))
                Console.WriteLine("Asked for item !");
        }

        public void OrderItem()
        {
            Console.Write("How many items do you want to order ? : ");
            int numberOfItems = Int32.Parse(Console.ReadLine());

            if (TypeCheck(numberOfItems))
            {
                for (int i = 0; i < numberOfItems; i++)
                {
                    Console.Write($"Insert the {i} item name : ");
                    string name = Console.ReadLine();
                    
                    if (TypeCheck(name))
                        Console.WriteLine("Item was ordered, you will pay when it arrives !");
                }
            }
        }
        
        // public void buyKey()
        // {
        //     if (Console.ReadKey(true).Key == ConsoleKey.X)
        //     {
        //         Console.Write("What item would you like to buy ?");
        //         string itemToBuy = Console.ReadLine();
        //         
        //         buyItems(buyerClass.ItemsList, itemToBuy);
        //     }
        //     else
        //         Console.WriteLine($"Wrong key pressed {Console.ReadKey()}, press [ X ]");
        // }
    }
}