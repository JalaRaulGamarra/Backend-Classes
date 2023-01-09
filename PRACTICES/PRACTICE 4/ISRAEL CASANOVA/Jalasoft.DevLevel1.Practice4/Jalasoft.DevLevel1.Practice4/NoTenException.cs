using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    public class NoTenException: Exception
    {
        public NoTenException(string message) : base(message)
        {
        }

        //public NoTenException(string message, Exception inner): base(message, inner)
        //{
        //}
    }
}
