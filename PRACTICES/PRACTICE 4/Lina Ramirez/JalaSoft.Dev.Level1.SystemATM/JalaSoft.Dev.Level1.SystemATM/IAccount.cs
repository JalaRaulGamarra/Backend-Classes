using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoft.Dev.Level1.SystemATM
{
    internal interface IAccount
    {
        public void Withdraw(double amountMoney);

        public void ShowOperations(double amountMoney);

        public void Deposit(double amountMoney);
                
        public void ShowBalance();
    }
}
