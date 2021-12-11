using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    public class Items
    {
        Buyer buyerClass;

        /* --------------------------------------------- */
        public List<string> ItemsList = new List<string>();

        /* --------------------------------------------- */
        public List<int> numberOfThingsBuyed = new List<int>();
        /* ---------------------------------------------------------- */

        
        /*---------------------------------------- MANAGING METHODS ----------------------------------------*/
        /* ------ CALCULATE STOCK (SELLER METHOD) ------ */
        public int calculateStock(List<string> listToPeform, int stock)
        {
            Console.WriteLine("Calculating stocks... This may take a while");
            Thread.Sleep(2000); // 2 seconds

            Console.Clear();
            Console.WriteLine($"Action performed, the stock is {listToPeform.Count}");
            Console.ReadLine();

            return listToPeform.Count;
        }

        /* ------ ADD ITEMS (MANAGER & SELLER METHOD) ------ */
        public void AddItems(List<string> listToAddItems)
        {
            Console.Write("How many items do you want to add ? :");
            int numberOFItemsToAdd = Int32.Parse(Console.ReadLine());
            
            if (TypeCheck(numberOFItemsToAdd))
            {
                for (int i = 0; i < numberOFItemsToAdd; i++)
                {
                    Console.WriteLine("Insert the name of the item : ");
                    string itemToAdd = Console.ReadLine();

                    if (TypeCheck(itemToAdd))
                    {
                        Console.Clear();
                        Console.WriteLine($"{itemToAdd} was added to {ItemsList}");
                        ItemsList.Add(itemToAdd);
                        Console.ReadLine();
                    }
                }  
            }
        }
        
        public void RemoveItems(List<string> listToRemoveItems)
        {

            Console.WriteLine("How many items do you want to remove ? : ");
            int numberOfItemsToRemove = Int32.Parse(Console.ReadLine());

            if (TypeCheck(numberOfItemsToRemove))
            {
                for (int i = 0; i < numberOfItemsToRemove; i++)
                {
                    Console.WriteLine("What item do you want to remove ? :");
                    string itemToRemove = Console.ReadLine();

                    if (TypeCheck(itemToRemove))
                    {
                        if (VerifyItemAvailability(ItemsList, itemToRemove))
                        {
                            Console.Clear();
                            Console.WriteLine($"{itemToRemove} was removed from {ItemsList}");
                            ItemsList.Remove(itemToRemove);
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
        }

        /* ------------------------------------------------------------------------------------------------------------------------------------- */
        
        /* ------ SELL ITEMS (SELLER METHOD) ------ */
        public void SellItems(List<string> listToSellItems)
        {
            Console.WriteLine("How many items do you want to sell ? : ");
            int numberOFItemsToSell = Int32.Parse(Console.ReadLine());

            if (TypeCheck(numberOFItemsToSell))
            {
                for (int i = 0; i < numberOFItemsToSell; i++)
                {
                    Console.WriteLine("What item do you want to sell ? :");
                    string itemToSell = Console.ReadLine();
                    
                    Console.WriteLine($"For how much do you want to sell item : {itemToSell}");
                    decimal price = Decimal.Parse(Console.ReadLine());

                    if (TypeCheck(itemToSell))
                    {
                        if (VerifyItemAvailability(ItemsList, itemToSell))
                        {
                            Console.Clear();
                            Console.WriteLine($"{itemToSell} was sold for {price}");
                            ItemsList.Remove(itemToSell);
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
        }
        
        /* ------------------------------------------------------------------------------------------------------------------------------------- */
        /* ------- STRING CHECKER ------- */
        public bool TypeCheck(string Item)
        {
            if (Item == null)
            {
                Console.WriteLine("You inserted a null value, insert a [ STRING ] ");
                return false;
            }
            else if (Item.GetType() != typeof(string))
            {
                Console.WriteLine("You inserted something diferent, insert a [ STRING ]");
                return false;
            }
            
            return true;
        }
        
        /* ------- INTEGER CHECKER ------- */
        public bool TypeCheck(int number)
        {
            if (number.GetType() != typeof(int))
            {
                Console.WriteLine("You inserted something wrong, not a [ INTEGER ]");
                return false;
            }

            return true;
        }

        public bool TypeCheck(decimal number)
        {
            if (number.GetType() != typeof(decimal))
            {
                Console.WriteLine("You inserted something wrong, not a [ DECIMAL ]");
                return false;
            }

            return true;
        }

        /* ------- ITEM VALABILITY CHECKER ------- */
        public bool VerifyItemAvailability(List<string> listToVerify, string itemToVerify)
        {
            int isItemAvailable = 0;

            foreach (string item in listToVerify)
                if (item == itemToVerify)
                    isItemAvailable++;

            if (isItemAvailable > 1)
                return true;
            else
                return false;
        }
    }
}