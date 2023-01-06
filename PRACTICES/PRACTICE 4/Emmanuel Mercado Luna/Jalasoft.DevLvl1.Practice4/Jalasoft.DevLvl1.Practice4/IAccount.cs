using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1.Practice4
{
    internal interface IAccount
    {
        void Deposit(int amount, string reference);
        void WithDraw(int amount);
        void ShowOperations();
        void ShowOperations(int limit);
        void ShowBalance();
    }
}
