using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1.Practice4
{
    internal class Account : IAccount
    {
        private int AccountBalance;
        private List<Operation> Operations;

        public Account(int accountBalance)
        {
            AccountBalance = accountBalance;
            Operations = new List<Operation>();
        }

        public void Deposit(int amount, string reference)
        {
            AccountBalance += amount;
            Operation deposit = new Operation(amount, OperationTypes.Deposit, reference);
            Operations.Add(deposit);
            Console.WriteLine($"Deposit of {amount} $ succesful");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"The actual amount of your account is: {AccountBalance} $");
        }

        public void ShowOperations()
        {

        }

        public void ShowOperations(int limit)
        {
            throw new NotImplementedException();
        }

        public void WithDraw(int amount)
        {
            AccountBalance -= amount;
            Console.WriteLine($"You withdraw the amount of \"{amount}\"$ from your account");
        }
    }
}
