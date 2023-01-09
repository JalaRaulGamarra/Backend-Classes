using ATMSystem.Model;
using ATMSystem.View;

var accountPrinter = new AccountPrinter();

accountPrinter.Deposit(100);
accountPrinter.Withdraw(100);

accountPrinter.ShowOperations(99);
accountPrinter.ShowOperations(100, OperationType.Deposit);
accountPrinter.ShowOperations(100, OperationType.Withdrawal);

accountPrinter.ShowBalance();
