using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoftDevLevel1.ATM
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException(): base("Not enough money in account")
        {
        }
    }
}
