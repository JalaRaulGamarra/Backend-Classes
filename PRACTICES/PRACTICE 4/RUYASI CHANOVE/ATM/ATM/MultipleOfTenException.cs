using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class MultipleOfTenException : Exception
    {
        public MultipleOfTenException() { }
        public MultipleOfTenException(string message) : base("The Number isn't multiple of Ten")
        {
        }
    }

}
