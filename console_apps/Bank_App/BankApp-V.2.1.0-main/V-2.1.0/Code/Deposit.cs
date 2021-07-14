using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class Deposit
    {
        public decimal DepositAmount { get; private set; }
        public string DepositName { get; }
        private DateTime DepositTime { get; }
        
        public Deposit(string depositName, decimal depositAmount, DateTime depositTime)
        {
            this.DepositName = depositName;
            this.DepositTime = depositTime;
            this.DepositAmount = depositAmount;
        }
    }
}

/* if (depositAmount > 0)
    Console.WriteLine($"Deposit wass succesful made form {depositName} with the amount of {depositAmount} \n Current Ballance : {depositAfterCalculation} \n TIME : {depositTime}");
else
    throw new ArgumentOutOfRangeException(nameof(depositAmount), "The amount you tried to deposit was negative !");
*/
