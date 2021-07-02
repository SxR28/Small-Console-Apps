using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class Account
    {
        public string AccountName { get; set; }
        public string AccountOwner { get; set; }
        public decimal Balance { get; private set; }

        private DateTime AccountCreationTime { get; }
        public int AccountSeed { get; }

        public Account(string accountName, string accountOwner, decimal accountInitialBalance, DateTime accountCreationTime)
        {
            this.AccountSeed = RandomNumber();
            this.AccountName = accountName;
            this.AccountOwner = accountOwner;
            this.AccountCreationTime = accountCreationTime;
            this.Balance = accountInitialBalance;
     
            Console.WriteLine($"Account was created on the name {accountName}, the account initiall balance is {accountInitialBalance}, the owner of the account is {accountOwner} -- Creation Time : {accountCreationTime}  \n  Account Seed : {AccountSeed}");
        }

        private int RandomNumber()
        {
            Random number = new Random();
            int accountSeed = number.Next(123450, 123460);

            return accountSeed;
        }

        public void AddDeposit(Deposit depositObj)
        {
            Balance += depositObj.DepositAmount;
            Console.WriteLine($"Deposit was succsefully , amount {depositObj.DepositAmount} \n Current balance : {Balance}");
        }

        public void TransactionCalc(Transaction transactionObj)
        {
            Balance -= transactionObj.TransactionAmount;
            Console.WriteLine($"Transaction was succsefully made from {AccountName} to {transactionObj.TransactionPerson} with the amount of {transactionObj.TransactionAmount} \n Current balance : {Balance}");
        }
    }
}
