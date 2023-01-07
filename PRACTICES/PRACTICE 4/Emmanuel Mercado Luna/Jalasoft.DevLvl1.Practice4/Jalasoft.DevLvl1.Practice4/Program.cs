using Jalasoft.DevLvl1.Practice4;

Account myAccount = new Account(100);

Operation deposit1 = new Operation(100, OperationTypes.Deposit, "Payment from Lucia");
Operation deposit2 = new Operation(125, OperationTypes.Deposit, "Payment from Sergio");
Operation deposit3 = new Operation(80, OperationTypes.Deposit, "Return of borrowing to Carly");
Operation withdraw1 = new Operation(500, OperationTypes.WithDraw, "Payment for Sneakers");
Operation withdraw2 = new Operation(50, OperationTypes.WithDraw, "Dinner at La Plaza");


myAccount.Deposit(deposit1);
try
{
    myAccount.Deposit(deposit2);
}
catch (NoTenMultiplierException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("|----------------------------|");
}

myAccount.Deposit(deposit3);

try
{
    myAccount.WithDraw(withdraw1);
}
catch(NegativeBalanceException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("|----------------------------|");
}

myAccount.WithDraw(withdraw2);

myAccount.ShowBalance();

myAccount.ShowOperations();

myAccount.ShowOperations(90);