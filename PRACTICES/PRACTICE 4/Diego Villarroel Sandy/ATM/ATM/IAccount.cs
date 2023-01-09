using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal interface IAccount
    {
        void Deposit(Deposits dep);
        void Withdraw(Withdraws with);
        void ShowOperations(string option);
        void ShowOperations(int val);
        void ShowBalance();
    }
}
