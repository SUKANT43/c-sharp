using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
    class TransactionHistory
    {
       public string Account_Number { get; set; }
       public int ToAccount { get; set; }
       public int TransactionAmount { get; set; }
    }
}
