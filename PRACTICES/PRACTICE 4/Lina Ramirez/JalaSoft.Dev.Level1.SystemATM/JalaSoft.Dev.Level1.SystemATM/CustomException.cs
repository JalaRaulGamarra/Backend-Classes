using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoft.Dev.Level1.SystemATM
{
    internal class CustomException: Exception
    {
        internal class NoFoundException : Exception
        {
            public NoFoundException() : base("Not enough money in account ")
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
