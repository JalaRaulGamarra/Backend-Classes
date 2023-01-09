using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    internal class InsufficientMoneyException : Exception
    {
        public InsufficientMoneyException()
        {
        }

        public InsufficientMoneyException(string message)
            : base(message)
        {
        }

        public InsufficientMoneyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
