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
            CheckAmount(operation);
            AccountBalance += operation.Amount;            
            Operations.Add(operation);
            InterfaceDrawer.Braker();
            Console.WriteLine($"Deposit of {operation.Amount} $ succesful");
            Console.WriteLine($"Ref. {operation.Reference}");
        }

        public void ShowBalance()
        {
            InterfaceDrawer.Braker();
            Console.WriteLine($"The actual amount of your account is: {AccountBalance} $");
        }

        public void ShowOperations(OperationTypes type)
        {
            int count = 1;

            var query = Operations.Where(operation => operation.Type == type);

            InterfaceDrawer.Braker();
            Console.WriteLine($"Operations of \"{Enum.GetName(typeof(OperationTypes), type)}\" type");
            foreach(var item in query)
            {
                Console.WriteLine($"({count}) Ref. {item.Reference} | Amount: {item.Amount} $");
                count++;
            }
        }

        public void ShowOperations(int limit)
        {
            var query = Operations.Where(operation => operation.Amount > limit);
            int count = 1;
            InterfaceDrawer.Braker();
            Console.WriteLine($"Operations greater than {limit} $");
            foreach (var item in query)
            {
                Console.WriteLine($"({count}) Type: {Enum.GetName(typeof(OperationTypes), item.Type)} | Amount: {item.Amount} $");
                count++;
            }
        }

        public void WithDraw(Operation operation)
        {
            CheckAmount(operation);
            AccountBalance -= operation.Amount;
            Operations.Add(operation);
            InterfaceDrawer.Braker();
            Console.WriteLine($"You withdraw the amount of \"{operation.Amount}\"$ from your account");
        }

        public void CheckAmount(Operation operation)
        {
            if (operation.Amount % 10 != 0)
            {
                throw new NoTenMultiplierException("ERROR: The account can only receive multiples of 10");
            }
            else if(operation.Amount > AccountBalance)
            {
                throw new NegativeBalanceException("ERROR: Not enough money in account");
            }
        }
    }
}
