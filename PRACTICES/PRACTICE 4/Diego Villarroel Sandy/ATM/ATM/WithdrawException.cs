using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class WithdrawException:Exception
    {
        const string messageWException = "not enough money in account ,{0} requested, {1} remains in balance";
        public WithdrawException(int amount, int balance) : base(string.Format(messageWException, amount, balance))
        {
           
        }
    }
}
