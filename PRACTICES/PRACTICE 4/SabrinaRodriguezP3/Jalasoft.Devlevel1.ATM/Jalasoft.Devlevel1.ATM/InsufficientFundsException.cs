using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.ATM
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
        : base("Not enough money in account")
        {
        }
    }
}
