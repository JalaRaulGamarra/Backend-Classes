using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1.Practice4
{
    public class NoTenMultiplierException : Exception
    {
        public NoTenMultiplierException() { }
        public NoTenMultiplierException(string message): base(message) { }
    }
}
