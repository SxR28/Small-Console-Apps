using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Basket : Items // For Buyer Option
    {
        public List<string> boughtThings { get; set; }
        public int numberOfThingsBought { get; set; }

        public void addItemInBasket(List<string> itemsList, List<string> boughtThings, string itemToAdd)
        {
            if (VerifyItemAvailability(itemsList, itemToAdd))
            {
                boughtThings.Add(itemToAdd);
                itemsList.Remove(itemToAdd);
            }
        }
    }
}