using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class DataBase
    {
        public List<Deposit> DepositsActions { get; } 
        public List<Draw> DrawsActions { get; } 
        public List<Transaction> TransactionsActions { get; }

        public DataBase()
        {
            DepositsActions = new List<Deposit>();
            DrawsActions = new List<Draw>();
            TransactionsActions = new List<Transaction>();
        }
    }
}
