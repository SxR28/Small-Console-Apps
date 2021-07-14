using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class Transaction
    {
        public string TransactionPerson { get; set; }
        public decimal TransactionAmount { get; private set; }
        private DateTime TransactionTime { get; }

        public Transaction(DateTime transactionTime, string transactePerson, decimal transactionAmount)
        {
            this.TransactionAmount = transactionAmount;
            this.TransactionTime = transactionTime;
            this.TransactionPerson = transactePerson;
        }

    }
}

/*
            if (transactionAmount > 0) 
            {
                Console.WriteLine($"Transaction succsesfully made from {transactionName} to {transactePerson} with the amount of {transactionAmount} \n Date : {transactionTime}");
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(transactionAmount), "You cant transacte with negative money !");
            }
            ==================================================================================================================================================================================== 
            if (transactionAmount > 0)
            {
                Console.WriteLine($"Transaction succsesfully made from {transactionName} to the company {transacteCompany} with the amount of {transactionAmount} \n Date : {transactionTime}");
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(transactionAmount), "You cant transacte with negative money !");
            }
*/
