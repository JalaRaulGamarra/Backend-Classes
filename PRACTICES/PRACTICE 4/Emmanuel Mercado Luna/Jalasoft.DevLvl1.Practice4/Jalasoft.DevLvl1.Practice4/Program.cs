using Jalasoft.DevLvl1.Practice4;

Account myAccount = new Account(100);

Operation deposit1 = new Operation(100, OperationTypes.Deposit, "Payment from Lucia");
Operation deposit2 = new Operation(85, OperationTypes.Deposit, "Payment from Sergio");
Operation withdraw1 = new Operation(50, OperationTypes.WithDraw, "Payment for Sneakers");

myAccount.Deposit(deposit1);
myAccount.Deposit(deposit2);

myAccount.ShowBalance();

myAccount.ShowOperations();

myAccount.ShowOperations(90);