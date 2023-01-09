using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Withdraws:Operations
    {
        public Withdraws(int amount )
        {
            this.amount = amount;
            this.type = "w";
        }
    }
}
