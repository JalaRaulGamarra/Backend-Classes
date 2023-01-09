using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1Practice4
{
    internal class NotMultipleOf10Exception : Exception
    {
        public NotMultipleOf10Exception() : base("The account can only receive multiples of 10")
        { 
        }
    }
}
