using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoftDevLevel1.ATM
{
    public class InvalidDepositException : Exception
    {
        public InvalidDepositException(): base("The account can only receive multiples of 10")
        {
        }
    }
}
