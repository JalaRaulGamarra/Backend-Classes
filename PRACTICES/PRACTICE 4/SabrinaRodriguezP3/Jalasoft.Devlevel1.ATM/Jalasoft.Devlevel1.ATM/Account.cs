using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.ATM
{
    public class Account : IAccount
    {
        // balance field
        public decimal Balance { get; set; }

        // operations field
        public List<string> Operations { get; set; }

        // Constructor
        public Account(decimal balance)
        {
            Balance = balance;
            Operations = new List<string>();
        }

        public void Deposit(decimal amount)
        {
            if (amount % 10 != 0)
            {
                throw new InvalidDepositException();
            }
            Balance += amount;
            Operations.Add("Deposited " + amount + " dollars");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundsException();
            }
            Balance -= amount;
            Operations.Add("Withdrew " + amount + " dollars");
        }

        public void ShowOperations(decimal value)
        {
            Console.WriteLine("Operations with value greater than or equal to " + value + ": ");
            var result = Operations.Where(x => Convert.ToDecimal(x.Split(' ')[1]) >= value);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }

        public void ShowOperations(string type)
        {
            Console.WriteLine("Operations of type " + type + ": ");
            var result = Operations.Where(x => x.Split(' ')[0] == type);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
