using ATM;

namespace ATMTest

{
    public class Account :IAccount
    {
        public double AccountBalance { get; set; }

        public Operations Op { get; set; }

        public Account(double initialBalance)
        {
            AccountBalance = initialBalance;
        }

        

        public void Deposit(double ammount)
        {
            try
            {
                AccountBalance += ammount;
            }
            catch (MultipleOfTenException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Withdraw(double ammount)
        {
            try
            {
                AccountBalance -= ammount;
            }
            catch(EmptyATMException ex)
            {
                Console.WriteLine(ex.Message);
            }
                // throw new NotImplementedException();
        }
        public void ShowOperations() {
            string[] strarr = new string[4];
            for(int i = 0; i < 4; i++) { 
              strarr.Append<string>( ((Operations)i).ToString());
            }
        }
        public string ShowBalance() {
            return "The current balance is: "+ AccountBalance;
        }
    }
}