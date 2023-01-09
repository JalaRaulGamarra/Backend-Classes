// See https://aka.ms/new-console-template for more information
using ATM;
Account<Operations> acc1 = new Account<Operations>("acc1");

Deposits dep1 = new Deposits(200);
acc1.Deposit(dep1);
Deposits dep2 = new Deposits(200);
acc1.Deposit(dep1);
Deposits dep3 = new Deposits(200);
acc1.Deposit(dep1);
Withdraws with1= new Withdraws(200);
acc1.Withdraw(with1);
Withdraws with2 = new Withdraws(600);
Deposits dep4 = new Deposits(595);
try 
{
    acc1.Withdraw(with2); 
}
catch (WithdrawException ex)
{
    Console.WriteLine(ex.Message);

}
try
{
    acc1.Deposit(dep4);
}
catch (DepositException ex2)
{
    Console.WriteLine(ex2.Message);
}
acc1.ShowBalance();
acc1.ShowOperations("w");

