using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoft.Dev.Level1.SystemATM
{
    internal class Account: IAccount
    {
        private double accountBalance;
        public List<Operations> operations;

        public Account()
        {
            accountBalance = 0;
            operations = new List<Operations>();
        }

        public void Deposit(double amountMoney)
        {
            accountBalance = accountBalance + amountMoney;
            Operations operation = new Operations(TypeOfTransaction.Deposit, amountMoney);
            operations.Add(operation);
        }

        public void ShowBalance()
        {
            Console.WriteLine($"The account balance is: {accountBalance}");
        }

        public void ShowOperations(double amountMoney)
        {
            List<Operations> query = operations.Where(e => e.AmountMoney >= amountMoney).ToList();
            foreach (Operations item in query)
            {
                Console.WriteLine($"Type of operation {item.Type} with value {item.AmountMoney}");
            }
        }

        public void Withdraw(double amountMoney)
        {
            accountBalance = accountBalance - amountMoney;
            Operations operation = new Operations(TypeOfTransaction.Whithdraw, amountMoney);
            operations.Add(operation);
        }

        
    }
}
