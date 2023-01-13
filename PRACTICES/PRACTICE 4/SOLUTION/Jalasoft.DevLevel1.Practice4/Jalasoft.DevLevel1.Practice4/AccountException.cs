using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    public abstract class AccountException : Exception
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
