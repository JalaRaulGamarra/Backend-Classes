using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    public class Account : IAccount
    {
        private List<Operation> operations = new List<Operation>();
        private int accountBalance = 0;
        public void Deposit(int value)
        {
            if (value % 10 != 0)
            {
                throw new AmountNotAllowedException();
            }
            accountBalance += value;
            var operation = new Operation() { Type = Type.Deposit, Value = value, OperationDate = DateTime.Now };
            operations.Add(operation);
        }

        public void Withdraw(int value)
        {
            if (value > accountBalance)
            {
                throw new NotEnoughMoneyException();
            }
            accountBalance -= value;
            var operation = new Operation() { Type = Type.Witdraw, Value = value, OperationDate = DateTime.Now };
            operations.Add(operation);
        }

        public void ShowOperations(Type type)
        {
            Console.WriteLine("Show operations by type");
            IEnumerable<Operation> query = null;
            string filterType = (type == Type.Deposit) ? "Deposit:" : "Withdraw:";
            query = operations.Where(o => o.Type== type).OrderByDescending(o => o.OperationDate);
            //query = from operation in operations where operation.Type == type orderby operation.OperationDate descending select operation;
            foreach (var item in query)
            {
                Console.WriteLine($"{filterType} {item.Value} - Date: {item.OperationDate}");
            }
        }

        public void ShowOperations(int value)
        {
            Console.WriteLine("Show operations by value");
            //var query = from operation in operations where operation.Value >= value orderby operation.OperationDate descending select operation;
            var query = operations.Where(operation => operation.Value >= value).OrderByDescending(operation => operation.OperationDate);
            foreach (var item in query)
            {
                string type = (item.Type == Type.Deposit) ? "Deposit:" : "Withdraw:";
                Console.WriteLine($"{type} {item.Value} - Date: {item.OperationDate}");
            }
        }

        public void ShowOperationsByID(int valu2)
        {

        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: {accountBalance}");
        }
    }
}
