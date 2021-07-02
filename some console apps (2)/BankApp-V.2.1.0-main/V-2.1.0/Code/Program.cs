
using System;

namespace TheBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataBase = new DataBase();

            Console.Write("What is your name : ");
            string inputAccountName = Console.ReadLine();

            Console.Write("Who is the owner of the account : ");
            string inputAccountOwner = Console.ReadLine();

            Console.Write("What is the desired amount you want your account to start ? : ");
            decimal initiallAccountBallance = int.Parse(Console.ReadLine());
            Console.Clear();

            var MyAccount = new Account(inputAccountName, inputAccountOwner, initiallAccountBallance, DateTime.Now, dataBase);

            Console.ReadLine();
            Console.Clear();

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"For the moment, as the bank is in development, you have the 5 standard bank option , you will need to type the number before the option\n");
                Console.WriteLine($"Type : \n 1. [ Deposit ] \n 2. [ Transaction ] \n 3. [ Draw ] \n 4. [ Account Details ] \n 5. [ Exit ] ");
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

                        Console.Write("What is the amount you want to draw : ");
                        decimal drawTransactionAmount = decimal.Parse(Console.ReadLine());

                        var Draw = new Draw(drawTransactionAmount, DateTime.Now);
                        MyAccount.DrawCalc(Draw);

                        Console.ReadLine();
                        break;

                    case '4':
                        Console.Clear();

                        Console.WriteLine($"What would you like to see : 1. Account Name \n 2. Account Owner \n 3. Account Balance \n 4. Account Deposits \n 5. Account Draws \n 6. Account Transactions");
                        Console.ReadLine();
                        Console.Clear();

                        Console.Write("What would you like to see ? : ");
                        char accountDetailsOption = char.Parse(Console.ReadLine());

                        if (accountDetailsOption == '1')
                        {
                            Console.WriteLine($"Account Name : {MyAccount.AccountName}");

                            Console.ReadLine();
                        }
                        else if (accountDetailsOption == '2') 
                        {
                            Console.WriteLine($"Account Owner : {MyAccount.AccountOwner}");

                            Console.ReadLine();
                        }
                        else if (accountDetailsOption == '3')
                        {
                            Console.WriteLine($"Account Balance : {MyAccount.Balance}");

                            Console.ReadLine();
                        }
                        else if (accountDetailsOption == '4')
                        {
                            Console.WriteLine($"Account Total Deposits : {dataBase.DepositsActions.Count}");

                            Console.ReadLine();
                        }
                        else if (accountDetailsOption == '5')
                        {
                            Console.WriteLine($"Account Total Draws : {dataBase.DrawsActions.Count}");

                            Console.ReadLine();
                        }
                        else if (accountDetailsOption == '6')
                        {
                            Console.WriteLine($"Account Total Transactions : {dataBase.TransactionsActions.Count}");

                            Console.ReadLine();
                        }

                        break;
                    case '5':
                        Environment.Exit(0);

                        break;
                }
            }
        }
    }
}