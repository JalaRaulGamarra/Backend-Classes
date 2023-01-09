using Jalasoft.DevLevel1.Practice4;

Console.WriteLine("Plese enter init balance");
int initBalance = Int32.Parse(Console.ReadLine());
Account Acc = new Account(initBalance);


while (true)
{
    Console.WriteLine("----------Choose an Option---------------");
    Console.WriteLine("1: Deposit ");
    Console.WriteLine("2: WithDraw");
    Console.WriteLine("3: Show All Operations");
    Console.WriteLine("4: Show Balance");
    Console.WriteLine("5: Show Specific Balance");
    Console.WriteLine("6: EXIT");
    Console.WriteLine("-----------------------------------------");

    try
    {
        int userInput = int.Parse(Console.ReadLine());
        if (userInput == 1)
        {
            Console.WriteLine("Enter the amount to be deposited");
            Operation op = new Operation();
            op.Transaction = Int32.Parse(Console.ReadLine());
            op.TypeTransaction = "+";
            Acc.Deposit(op);
        }
        else if (userInput == 2)
        {
            Console.WriteLine("Enter the amount to be withdrawn");
            Operation op2 = new Operation();
            op2.Transaction = Int32.Parse(Console.ReadLine());
            op2.TypeTransaction = "-";
            Acc.WithDraw(op2);
        }
        else if (userInput == 3)
        {
            Acc.ShowOperations();
        }
        else if (userInput == 4)
        {
            Acc.ShowBalance();
        }
        else if (userInput == 5)
        {
            Console.WriteLine("Enter the amount to be filtered");
            var amount = Int32.Parse(Console.ReadLine());
            Acc.ShowOperations(amount);
        }
        else if (userInput == 6)
        {
            break;
        }

    }
    catch (NoMoneyException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (NoTenException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}







