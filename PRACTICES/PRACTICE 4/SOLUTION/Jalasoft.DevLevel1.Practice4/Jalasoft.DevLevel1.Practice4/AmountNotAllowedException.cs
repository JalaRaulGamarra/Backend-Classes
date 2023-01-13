using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    internal class AmountNotAllowedException: AccountException
    {
        public AmountNotAllowedException()
        {
            ErrorCode = 2;
            ErrorMessage = "The account can only receive multiples of 10";
        }
    }
}
