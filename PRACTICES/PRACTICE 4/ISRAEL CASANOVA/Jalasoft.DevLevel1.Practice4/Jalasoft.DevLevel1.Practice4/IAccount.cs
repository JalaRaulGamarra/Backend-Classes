using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    internal interface IAccount
    {
        void Deposit(Operation op);
        void WithDraw(Operation op);
        void ShowBalance();
        void ShowOperations(int Sendvalue);
    }
}
