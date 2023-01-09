using Jalasoft.Devlevel1.ATM;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ATM Program");
        Account myAccount = new Account();
        myAccount.Deposit(100);
        myAccount.ShowBalance();
        myAccount.Deposit(30);
        myAccount.ShowBalance();
        myAccount.ShowOperations();
        myAccount.ShowOperations(70);
    }
}