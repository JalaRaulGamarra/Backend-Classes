using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    internal class DepositNotMultipleOfTenException : Exception
    {
        public DepositNotMultipleOfTenException()
        {
        }

        public DepositNotMultipleOfTenException(string message)
            : base(message)
        {
        }

        public DepositNotMultipleOfTenException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
