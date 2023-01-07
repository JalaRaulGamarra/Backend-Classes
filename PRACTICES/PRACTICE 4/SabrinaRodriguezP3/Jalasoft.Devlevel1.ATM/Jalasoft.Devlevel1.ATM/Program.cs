using Jalasoft.Devlevel1.ATM;

//try
//{
//    Account account = new Account(100);
//    account.Deposit(100);
//    account.Withdraw(50);
//    account.ShowOperations(50);
//    account.ShowOperations("Deposited");
//    account.ShowBalance();
//}
//catch (InsufficientFundsException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (InvalidDepositException ex)
//{
//    Console.WriteLine(ex.Message);
//}



try
{
    Account account = new Account(100);
    account.Deposit(40);
    account.Withdraw(200);
    account.ShowOperations(40);
    account.ShowOperations("Deposited");
    account.ShowBalance();
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidDepositException ex)
{
    Console.WriteLine(ex.Message);
}
