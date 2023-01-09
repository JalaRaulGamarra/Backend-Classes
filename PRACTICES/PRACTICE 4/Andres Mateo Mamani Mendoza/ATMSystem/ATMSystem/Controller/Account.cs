using ATMSystem.Model;

namespace ATMSystem.Controller
{
    public class Account : IAccount
    {
        private decimal balance;
        private List<Operation> operations;

        public Account()
        {
            this.balance = 0;
            this.operations = new List<Operation>();
        }

        public void Deposit(decimal amount)
        {
            if (amount % 10 != 0)
            {
                throw new Exception("The account can only receive multiples of 10");
            }

            this.balance += amount;
            Operation newOperation = new(OperationType.Deposit, amount);
            this.operations.Add(newOperation);
        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.balance)
            {
                throw new Exception("Not enough money in account");
            }

            this.balance -= amount;
            Operation newOperation = new(OperationType.Withdrawal, amount);
            this.operations.Add(newOperation);
        }

        public List<Operation> GetOperations(decimal amount)
        {
            return this.operations.Where(operation => operation.Amount >= amount).ToList();
        }

        public List<Operation> GetOperations(decimal amount, OperationType type)
        {
            return this.operations.Where(operation => operation.Type == type && operation.Amount == amount).ToList(); ;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }
    }
}