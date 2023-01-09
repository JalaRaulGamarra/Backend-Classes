using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.ATM
{
    internal class Account : IAccount
    {

        private double accountBalance;
        private List<Operations<OperationsType, double>> operations = new List<Operations<OperationsType, double>>();
        public Account()
        {
            accountBalance = 0;
        }

        public void Deposit(double ammount)
        {
            accountBalance += ammount;
            Operations<OperationsType, double> deposit = new Operations<OperationsType, double>();
            deposit.SaveOperation(OperationsType.deposit, ammount);
            operations.Add(deposit);
        }
        public void Withdraw(double ammount)
        {
            accountBalance -= ammount;
            Operations<OperationsType, double> withdraw = new Operations<OperationsType, double>();
            withdraw.SaveOperation(OperationsType.withdraw, ammount);
            operations.Add(withdraw);
        }
        public void ShowBalance()
        {
            Console.WriteLine(accountBalance);
        }
        public void ShowOperations()
        {
            operations.ForEach(op => op.GetInfo());
        }
        public void ShowOperations(double ammount)
        {
            var query = operations.Where(op => op.amount >= ammount);
            foreach (var i in query)
            {
                i.GetInfo();
            }
        }

    }
}
