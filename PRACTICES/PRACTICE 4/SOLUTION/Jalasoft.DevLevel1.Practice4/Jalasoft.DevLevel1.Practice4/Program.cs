// See https://aka.ms/new-console-template for more information
using Jalasoft.DevLevel1.Practice4;
using Type = Jalasoft.DevLevel1.Practice4.Type;

IAccount account = new Account();


    try
    {
        account.Deposit(100);
        account.Deposit(130);
        account.Deposit(10);
        account.Deposit(80);
        account.Deposit(150);
        account.ShowBalance();
        account.Withdraw(100);
        account.Withdraw(20);
        account.Withdraw(30);
        account.Withdraw(100);
        account.ShowBalance();
        account.ShowOperations(50);
        account.ShowOperations(Type.Deposit);
        account.ShowOperations(Type.Witdraw);
    }
    catch (AccountException ex)
    {
        Console.WriteLine(ex.ErrorMessage);
        Console.WriteLine($"Error Code: {ex.ErrorCode}");
    }