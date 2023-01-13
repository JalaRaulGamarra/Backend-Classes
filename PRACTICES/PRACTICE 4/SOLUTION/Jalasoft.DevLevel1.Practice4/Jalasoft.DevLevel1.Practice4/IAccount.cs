using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    public interface IAccount
    {
        public void Withdraw(int value);
        public void Deposit(int value);
        public void ShowOperations(int value);
        public void ShowOperations(Type type);
        public void ShowBalance();
    }
}
