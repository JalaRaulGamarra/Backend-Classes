using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class EmptyATMException : Exception
    {
        public EmptyATMException() { }
        public EmptyATMException(string message) : base("The ATM is Empty")
        {
        }
    }
   
}
