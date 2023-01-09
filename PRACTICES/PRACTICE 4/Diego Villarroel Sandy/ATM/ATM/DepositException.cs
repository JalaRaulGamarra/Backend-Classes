using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class DepositException:Exception
    {
        const string messageDexception = "The account can only receive multiples of 10 not {0}, remains {1} in balance";
        public DepositException(int amount, int balance) : base(string.Format(messageDexception, amount, balance))
        {

        }
    }
}
