using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1Practice4
{
    public class Account : IAccount
    {
        public int AccBalance { get; set; }
        public List<KeyValuePair<string, int>> Operations { get; set; }

        public Account(int balance) 
        { 
           this.AccBalance = balance;
           this.Operations= new List<KeyValuePair<string, int>>();            
            Operations.Add(new KeyValuePair<string, int>("Account Creation", AccBalance));

        }

        public void Deposit(int ammount)
        {
            if((ammount%10) != 0)
            {
                throw new NotMultipleOf10Exception();
            }
            AccBalance += ammount;
            Operations.Add(new KeyValuePair<string, int>("Deposit", ammount));
        }

        public void WithDraw(int ammount)
        {
            if(ammount > AccBalance) 
            { 
                throw new NotEnoughMoneyException();
            }        
            AccBalance -= ammount;
            Operations.Add(new KeyValuePair<string, int>("Withdrawal", ammount));
        }

        public void ShowOperations(string typeOfOperation)
        {
            var query = Operations.Where(item => item.Key == typeOfOperation);
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public void ShowOperations(int ammount)
        {
            var query = Operations.Where(item => item.Value == ammount);
            foreach(var item in query)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: {AccBalance}");
        }
    }
}
