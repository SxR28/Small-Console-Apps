﻿
using System;

namespace TheBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name : ");
            string inputAccountName = Console.ReadLine();

            Console.Write("Who is the owner of the account : ");
            string inputAccountOwner = Console.ReadLine();

            Console.Write("What is the desired amount you want your account to start ? : ");
            decimal initiallAccountBallance = int.Parse(Console.ReadLine());
            Console.Clear();

            Account MyAccount = new Account(inputAccountName, inputAccountOwner, initiallAccountBallance, DateTime.Now);

            Console.ReadLine();
            Console.Clear();

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"For the moment, as the bank is in development, you have the 3 standard bank option : \n - [ DEPOSIT ] \n - [ TRANSACTION ] \n - [ DRAW ] \n");
                Console.WriteLine($"Type :  \n - [ deposit ] \n - [ transaction ] \n - [ draw ]");
                Console.ReadLine();
                Console.Clear();

                Console.Write("What would you like to do today ? : ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "deposit":
                        Console.Clear();

                        Console.Write("What is the amount you want to deposit : ");
                        decimal inputDepositAmount = int.Parse(Console.ReadLine());

                        Deposit MyDeposit = new Deposit(MyAccount.AccountName, inputDepositAmount, DateTime.Now);
                        MyAccount.AddDeposit(MyDeposit);

                        break;

                    case "transaction":
                        Console.Clear();

                        Console.Write("What is the amount you want to transacte : ");
                        decimal inputTransactionAmount = int.Parse(Console.ReadLine());

                        Console.Write("To who would you like to transacte : ");
                        string inputTransactionName = Console.ReadLine();

                        Transaction Transaction = new Transaction(DateTime.Now, MyAccount.AccountName, inputTransactionAmount);
                        MyAccount.TransactionCalc(Transaction);

                        break;
                }
            }
        }
    }
}