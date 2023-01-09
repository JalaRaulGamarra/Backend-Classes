using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.ATM
{
    internal interface IAccount
    {
        public void Deposit(double ammount);
        public void Withdraw(double ammount);
        public void ShowOperations();
        public void ShowBalance();
    }
}
