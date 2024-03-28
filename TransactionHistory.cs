using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System_v2
{
    public class TransactionHistory
    {
        public int TransID { get; private set; }
        public int AccID { get; private set;}
        public string TransMemo { get; private set; } = string.Empty;
        public decimal Balance { get; private set; }

    }
}
