using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    internal class NotEnoughMoneyException : AccountException
    {
        public NotEnoughMoneyException()
        {
            ErrorCode= 1;
            ErrorMessage = "Not enough money in account";
        }
    }
}
