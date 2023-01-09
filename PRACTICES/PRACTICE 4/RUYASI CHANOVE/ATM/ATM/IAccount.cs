namespace ATMTest
{
    public interface IAccount
    {
        double AccountBalance { get; set; }
        public enum Operations { Deposit, Withdraw, ShowOperations, ShowBalance }
        internal void Deposit(double ammount);
        internal void Withdraw(double ammount);
        internal void ShowOperations();
        internal string ShowBalance();

    }
}