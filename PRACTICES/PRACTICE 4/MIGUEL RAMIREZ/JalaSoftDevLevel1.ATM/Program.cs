using JalaSoftDevLevel1.ATM;


Account account = new Account("1234-5678-9123-4567", 100);
Transaction transaction = new Transaction();

/*Deposit*/
try
{
    transaction = new Transaction()
    {
        Type = OperationType.Deposit,
        Amount = 500,
        Date = new DateTime(2023, 1, 7, 12, 0, 0),
    };
    account.Deposit(transaction);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidDepositException ex)
{
    Console.WriteLine(ex.Message);
}




/*Withdrawal*/
try
{
    transaction = new Transaction()
    {
        Type = OperationType.WithDrawal,
        Amount = 200,
        Date = new DateTime(2023, 1, 8, 12, 0, 0),
    };
    account.WithDraw(transaction);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NotEnoughMoneyException ex)
{
    Console.WriteLine(ex.Message);
}


/*Show operations*/
account.ShowOperations();

///*Show operations by amount*/
account.ShowOperations(amount: 100);

/////*Show operations by type*/
account.ShowOperations(type: OperationType.WithDrawal);

/////*Show operations by date 01 Jan 2023 and today*/
account.ShowOperations(startDate: new DateTime(2023, 1, 1, 0, 0, 0), endDate: DateTime.Now);

///*Show balance*/
account.ShowBalance();