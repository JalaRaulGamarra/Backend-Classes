using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoftDevLevel1.ATM
{
    public class Transaction
    {
        public OperationType Type { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        
    }
}
