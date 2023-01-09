using Jalasoft.DevLvl1Practice4;
//Create account
Account MichAccount = new(1000);

//Deposit
MichAccount.Deposit(100);
MichAccount.Deposit(20);
try
{
    MichAccount.Deposit(305);

}
catch (NotMultipleOf10Exception nm10)
{
    Console.WriteLine(nm10.Message);
}
// Withdraw
MichAccount.WithDraw(20);
MichAccount.WithDraw(20);
try
{
    MichAccount.WithDraw(2000);
}
catch (NotEnoughMoneyException nem)
{
    Console.WriteLine(nem.Message);
}

//Show all operations
Console.WriteLine("\nShowing all Deposits\n");
MichAccount.ShowOperations("Deposit");
Console.WriteLine("\nShowing all WithDrawals\n");
MichAccount.ShowOperations("Withdrawal");

//Show filtered operations
Console.WriteLine("\nShowing operations filtered by ammount\n");
MichAccount.ShowOperations(20);

//Show balance
Console.WriteLine("\n");
MichAccount.ShowBalance();