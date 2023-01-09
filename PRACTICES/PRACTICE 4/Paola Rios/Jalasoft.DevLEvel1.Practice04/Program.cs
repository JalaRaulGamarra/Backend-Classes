// See https://aka.ms/new-console-template for more information
using Jalasoft.DevLEvel1.Practice04;

Console.WriteLine("Hello, World!");
Account account1= new Account();
account1.Deposit(10);
account1.Deposit(20);
account1.Deposit(80);
account1.ShowBalance();
account1.ShowOperation(30);
account1.ShowOperation();
Console.WriteLine("==============");
account1.Withdraw(5);

account1.ShowOperation(30);
account1.ShowOperation();
account1.ShowBalance();
try
{
    account1.Withdraw(200);
}
catch(NotEnoughMoneyException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    account1.Deposit(3);
}
catch (NotMultipleOfTenException ex)
{
    Console.WriteLine(ex.Message);
}



