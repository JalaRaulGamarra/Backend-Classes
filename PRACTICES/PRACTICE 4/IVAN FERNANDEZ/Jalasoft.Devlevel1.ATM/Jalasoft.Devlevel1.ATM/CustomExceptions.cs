using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.ATM
{
    internal class CustomExceptions
    {
        internal class NotEnoughMoneyException: Exception
        {
            public NotEnoughMoneyException() : base("Not enough money in account ")
            {
            }
        }

        internal class NotMultipleOfTenException : Exception
        {
            public NotMultipleOfTenException() : base("The account can only receive multiples of 10")
            {
            }
        }

    }
}
