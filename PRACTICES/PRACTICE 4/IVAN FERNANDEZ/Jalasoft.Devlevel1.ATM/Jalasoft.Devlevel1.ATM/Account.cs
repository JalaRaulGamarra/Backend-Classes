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
            if (ammount % 10 == 0)
            {
                accountBalance += ammount;
                Operations<OperationsType, double> deposit = new Operations<OperationsType, double>();
                deposit.SaveOperation(OperationsType.deposit, ammount);
                operations.Add(deposit);
                Console.WriteLine("deposit completed.");
            }
            else throw new CustomExceptions.NotMultipleOfTenException();
        }

        public void Withdraw(double ammount)
        {
            if (accountBalance >= ammount)
            {
                accountBalance -= ammount;
                Operations<OperationsType, double> withdraw = new Operations<OperationsType, double>();
                withdraw.SaveOperation(OperationsType.withdraw, ammount);
                operations.Add(withdraw);
                Console.WriteLine("withdraw completed.");
            }
            else throw new CustomExceptions.NotEnoughMoneyException();
        }

        public void ShowBalance()
        {
            Console.WriteLine("Account Balance: ");
            Console.WriteLine(accountBalance);
        }

        public void ShowOperations()
        {
            Console.WriteLine($"All Transactions:");
            operations.ForEach(op => op.GetInfo());
        }

        public void ShowOperations(double ammount)
        {
            Console.WriteLine($"Transactions over {ammount}: ");
            var query = operations.Where(op => op.amount >= ammount);
            foreach (var i in query)
            {
                i.GetInfo();
            }
        }

    }
}
