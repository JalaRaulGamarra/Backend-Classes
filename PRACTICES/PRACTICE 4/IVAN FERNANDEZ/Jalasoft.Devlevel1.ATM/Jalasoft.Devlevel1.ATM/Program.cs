using Jalasoft.Devlevel1.ATM;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*$* ATM Program *$*");
        Account myAccount = new Account();
        try
        {
            myAccount.Deposit(100);
            myAccount.Deposit(30);
            myAccount.ShowBalance();
            myAccount.Withdraw(100);
            myAccount.ShowBalance();

            myAccount.ShowOperations();
            myAccount.ShowOperations(70);

            //myAccount.Deposit(35);
            myAccount.Withdraw(200);

        }
        catch (CustomExceptions.NotEnoughMoneyException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (CustomExceptions.NotMultipleOfTenException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something Wrong!");
        }
        finally
        {
            Console.WriteLine("*$* ATM session ended *$*");
        }
    }
}