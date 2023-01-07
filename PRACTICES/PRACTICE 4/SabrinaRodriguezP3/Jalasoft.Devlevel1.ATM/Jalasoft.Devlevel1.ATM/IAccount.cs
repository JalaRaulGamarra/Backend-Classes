using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.ATM
{
    public interface IAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void ShowOperations(decimal value);
        void ShowOperations(string type);
        void ShowBalance();
    }
}
