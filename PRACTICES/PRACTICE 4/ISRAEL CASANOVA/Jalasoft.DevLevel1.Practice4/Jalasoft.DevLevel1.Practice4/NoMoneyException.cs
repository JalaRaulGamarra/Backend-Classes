using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    public class NoMoneyException: Exception
    {
        public NoMoneyException(string message) : base(message)
        {
        }

        //public NoMoneyException(string message, Exception inner) : base(message, inner)
        //{
        //}
    }
}
