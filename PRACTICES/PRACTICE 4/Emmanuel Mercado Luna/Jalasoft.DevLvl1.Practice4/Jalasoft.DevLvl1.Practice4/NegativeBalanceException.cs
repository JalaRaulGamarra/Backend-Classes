using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1.Practice4
{
    public class NegativeBalanceException : Exception
    {
        public NegativeBalanceException() {
        }

        public NegativeBalanceException(string message) : base(message) 
        {
        }

        public NegativeBalanceException(string message, Exception inner) : base(message, inner) 
        {
        }
    }
}
