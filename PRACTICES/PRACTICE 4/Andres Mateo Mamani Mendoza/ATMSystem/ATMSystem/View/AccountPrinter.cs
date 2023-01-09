using ATMSystem.Controller;
using ATMSystem.Model;

namespace ATMSystem.View
{
    public class AccountPrinter
    {
        private Account account;

        public AccountPrinter()
        {
            this.account = new Account();
        }

        public void Deposit(decimal amount)
        {
            try
            {
                this.account.Deposit(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Withdraw(decimal amount)
        {
            try
            {
                this.account.Withdraw(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ShowOperations(decimal amount)
        {
            var operationList = this.account.GetOperations(amount);

            if (operationList.Count == 0)
            {
                Console.WriteLine($"There are no operations with the amount : {amount}");
            }
            else
            {
                Console.WriteLine("Type   :   Value");
                foreach (Operation operation in operationList)
                {
                    Console.WriteLine(operation.GetDetails());
                }
            }

        }

        public void ShowOperations(decimal amount, OperationType type)
        {
            var operationList = this.account.GetOperations(amount, type);

            if (operationList.Count == 0)
            {
                Console.WriteLine($"There are no operations with the amount : {amount}, type: {type}");
            }
            else
            {
                Console.WriteLine("Type   :   Value");
                foreach (Operation operation in operationList)
                {
                    Console.WriteLine(operation.GetDetails());
                }
            }

        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current balance: {this.account.GetBalance()}");
        }
    }
}