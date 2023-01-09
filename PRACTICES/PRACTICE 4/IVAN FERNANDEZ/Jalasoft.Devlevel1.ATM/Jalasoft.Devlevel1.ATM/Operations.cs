using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.ATM
{
    internal class Operations<TOperationStype, TAmount>
    {
        internal TOperationStype Operation;
        internal TAmount amount;
        internal void SaveOperation(TOperationStype operation, TAmount amount)
        {
            this.Operation = operation;
            this.amount = amount;
        }
        internal void GetInfo()
        {
            Console.WriteLine($"Transaction: {this.Operation} ; Amount: {this.amount}");
        }
        
    }
}
