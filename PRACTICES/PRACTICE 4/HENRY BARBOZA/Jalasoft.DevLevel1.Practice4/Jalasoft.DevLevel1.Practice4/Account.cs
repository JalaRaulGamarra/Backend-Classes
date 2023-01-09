using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    internal class Account : IAccount
    {
        private int acountBalance = 0;
        private List<Tuple<string,int>> operations = new List<Tuple<string, int>>();

        public string Deposit(int amount)
        {
            CheckValidAmout(amount);
            acountBalance += amount;
            operations.Add(new Tuple<string, int>("Deposit", amount));
            return $"Successful deposit ({amount})";
        }

        public string Withdraw(int amount)
        {
            CheckValidAmout(amount);
            if (amount > acountBalance)
            {
                throw new InsufficientMoneyException("Not enough money in account");
            }
            acountBalance -= amount;
            operations.Add(new Tuple<string, int>("Withdraw", amount));
            return $"Successful withdrawal ({amount})";
        }

        public string ShowOperations(int value)
        {
            string message = "";
            var query = operations.Where(operation => operation.Item2 >= 100);
            foreach (Tuple<string, int> operation in query)
            {
                message += $"{operation.Item1}: {operation.Item2} \n";
            }
            return message;
        }

        public string ShowOperations(string typeOperation)
        {
            string message = "";
            var query = operations.Where(operation => operation.Item1 == typeOperation);
            foreach (Tuple<string, int> operation in query)
            {
                message += $"{operation.Item1}: {operation.Item2} \n";
            }
            return message;
        }

        public string ShowBalance()
        {
            return $"Account balance: {acountBalance}";
        }

        private void CheckValidAmout(int amount)
        {
            if (amount % 10 != 0)
            {
                throw new DepositNotMultipleOfTenException("The account can only receive multiples of 10");
            }
        }

    }
}
