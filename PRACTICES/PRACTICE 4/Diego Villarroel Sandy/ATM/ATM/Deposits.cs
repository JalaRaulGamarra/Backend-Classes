using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Deposits:Operations
    {
        public Deposits(int amount)
        {
            this.amount = amount;
            this.type = "d";

        }
    }
}
