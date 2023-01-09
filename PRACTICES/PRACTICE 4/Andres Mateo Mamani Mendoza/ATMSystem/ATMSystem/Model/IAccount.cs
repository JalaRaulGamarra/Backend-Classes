namespace ATMSystem.Model
{
    public interface IAccount
    {
        public void Deposit(decimal amount);
        public void Withdraw(decimal amount);
        public List<Operation> GetOperations(decimal amount);
        public List<Operation> GetOperations(decimal amount, OperationType type);
        public decimal GetBalance();
    }
}