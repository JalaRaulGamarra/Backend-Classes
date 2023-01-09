using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1Practice4
{
    internal class NotEnoughMoneyException :Exception
    {
        public NotEnoughMoneyException() : base("Not enough money in account")
        { 
        }
    }
}
