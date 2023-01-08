using Jalasoft.DevLevel1.Practice4;

IAccount account1 = new Account();

Console.WriteLine("#### ATM ####");
Console.WriteLine(account1.Deposit(100));
Console.WriteLine(account1.Withdraw(50));
Console.WriteLine(account1.Deposit(190));
Console.WriteLine(account1.Withdraw(110));
Console.WriteLine(account1.Deposit(40));
Console.WriteLine("\nAll History");
Console.WriteLine(account1.ShowOperations());
Console.WriteLine("Filtered history (>=100)");
Console.WriteLine(account1.ShowOperations(100));
Console.WriteLine(account1.ShowBalance());

try
{
    Console.WriteLine(account1.Withdraw(300));
}
catch(InsufficientMoneyException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


try
{
    Console.WriteLine(account1.Withdraw(58));
}
catch (DepositNotMultipleOfTenException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}