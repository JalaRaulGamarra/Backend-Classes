using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1.Practice4
{
    public class Account : IAccount
    {
        public int AccountBalance { get; private set; }
        private List<Operation> Operations;

        public Account(int accountBalance)
        {
            AccountBalance = accountBalance;
            Operations = new List<Operation>();
        }

        public void Deposit(Operation operation)
        {
            AccountBalance += operation.Amount;            
            Operations.Add(operation);
            Console.WriteLine($"Deposit of {operation.Amount} $ succesful");
            Console.WriteLine($"Reference: {operation.Comment}");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"The actual amount of your account is: {AccountBalance} $");
        }

        public void ShowOperations()
        {
            int count = 1;
            foreach(var item in Operations)
            {
                Console.WriteLine($"({count}) Type: {Enum.GetName(typeof(OperationTypes),item.Type)} | Amount: {item.Amount} $");
                count++;
            }
        }

        public void ShowOperations(int limit)
        {
            var query = Operations.Where(operation => operation.Amount > limit);
            int count = 1;
            foreach (var item in query)
            {
                Console.WriteLine($"({count}) Type: {Enum.GetName(typeof(OperationTypes), item.Type)} | Amount: {item.Amount} $");
                count++;
            }
        }

        public void WithDraw(Operation operation)
        {
            AccountBalance -= operation.Amount;
            Console.WriteLine($"You withdraw the amount of \"{operation.Amount}\"$ from your account");
        }
    }
}
