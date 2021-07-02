
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

            var MyAccount = new Account(inputAccountName, inputAccountOwner, initiallAccountBallance, DateTime.Now);

            Console.ReadLine();
            Console.Clear();

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"For the moment, as the bank is in development, you have the 3 standard bank option , you will need to type the number before the option : \n - [ DEPOSIT ] \n - [ TRANSACTION ] \n - [ DRAW ] \n");
                Console.WriteLine($"Type :  \n 1. [ deposit ] \n 2. [ transaction ] \n 3. [ draw -- INCOMING ] \n 4. Exit");
                Console.ReadLine();
                Console.Clear();

                Console.Write("What would you like to do today ? : ");
                char option = char.Parse(Console.ReadLine());

                
                switch (option)
                {
                    case '1':
                        Console.Clear();

                        Console.Write("What is the amount you want to deposit : ");
                        decimal inputDepositAmount = decimal.Parse(Console.ReadLine());

                        var MyDeposit = new Deposit(MyAccount.AccountName, inputDepositAmount, DateTime.Now);
                        MyAccount.AddDeposit(MyDeposit);

                        Console.ReadLine();
                        break;

                    case '2':
                        Console.Clear();

                        Console.Write("What is the amount you want to transacte : ");
                        decimal inputTransactionAmount = decimal.Parse(Console.ReadLine());

                        Console.Write("To who would you like to transacte : ");
                        string inputTransactionName = Console.ReadLine();

                        var Transaction = new Transaction(DateTime.Now, MyAccount.AccountName, inputTransactionAmount);
                        MyAccount.TransactionCalc(Transaction);

                        Console.ReadLine();
                        break;

                    case '3':
                        Console.Clear();

                        Console.WriteLine("What is the amount you want to draw : ");
                        decimal drawTransactionAmount = decimal.Parse(Console.ReadLine());

                        var Draw = new Draw(drawTransactionAmount, DateTime.Now);
                        MyAccount.DrawCalc(Draw);

                        Console.ReadLine();
                        break;

                    case '4':
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}