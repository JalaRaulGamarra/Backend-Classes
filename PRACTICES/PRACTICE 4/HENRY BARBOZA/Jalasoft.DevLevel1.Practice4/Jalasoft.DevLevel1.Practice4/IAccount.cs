using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    internal interface IAccount
    {
        internal string Deposit(int amount);
        internal string Withdraw(int amount);
        internal string ShowOperations(int value);
        internal string ShowOperations();
        internal string ShowBalance();

    }
}
