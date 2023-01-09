using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLEvel1.Practice04
{
    public class Account : IAccount
    {
        private double accountBalance = 0;
        private List<Operation> Operations = new List<Operation>();

        public void Deposit(int amount)
        {
            if (amount % 10 != 0) 
            {
                throw new NotMultipleOfTenException();
            }
            accountBalance += amount;
            Operations.Add(new Operation(){InitialBalance=accountBalance,EndBalance= accountBalance, Amount=amount,TransactionType= OperationType.Deposit });

        }
        public void ShowBalance() => Console.WriteLine("The account balance is:{0}", accountBalance);

        public void ShowOperation(double mount)
        {
            var query = Operations.Where(item => item.Amount >= mount);
            foreach (var x in query)
            {
                Console.WriteLine("The transactions is greater than {0}, is the following deposit :{1}", mount, x.Amount);
            }
        }
        public void ShowOperation()
        {
            Operations.ForEach(x => x.Show());
        }
        public void Withdraw(double amount)
        {
            if (amount > accountBalance)
            {
                throw new NotEnoughMoneyException();
            }
           accountBalance -= amount;
           Operations.Add(new Operation() { InitialBalance = accountBalance, EndBalance = accountBalance, Amount = amount, TransactionType = OperationType.WithDraw});

        }   
    }
}
