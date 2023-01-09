// See https://aka.ms/new-console-template for more information
using JalaSoft.Dev.Level1.SystemATM;
using static JalaSoft.Dev.Level1.SystemATM.CustomException;

Console.WriteLine("Hello, World!");


Account myAccount = new Account();

try
{
    myAccount.Deposit(1000);
    myAccount.Deposit(598);
    myAccount.Withdraw(40);
    myAccount.Withdraw(473);
    myAccount.Withdraw(2000);
    myAccount.ShowBalance();
    myAccount.ShowOperations(20);
}
catch (NoFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NotMultipleOfTenException ex)
{
    Console.WriteLine(ex.Message);
}
