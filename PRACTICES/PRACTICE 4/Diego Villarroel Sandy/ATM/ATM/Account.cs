using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Account <TAccount>: IAccount
        where TAccount : Operations
    {
        public int balance;
        public string name;
        public Account(string nameofAcount)
        {
            
            name= nameofAcount;
        }
        
        public List<Operations> ListofOperations = new List<Operations>();
        public void Deposit(Deposits dep) 
        {
            if (dep.amount%10!=0)
            {
                throw new DepositException(dep.amount, balance);
            }
            balance = balance + dep.amount;
            ListofOperations.Add(dep);
           
        }
        public void Withdraw(Withdraws with) 
        {
            if (with.amount > balance)
            {
                throw new WithdrawException(with.amount, balance); 
            }
            balance = balance - with.amount;
            ListofOperations.Add(with);
        }
        public void ShowOperations(int val)
        {
            Console.WriteLine("before query");
            var query = ListofOperations.Select(x => x).OrderBy(x=>x.amount);
            foreach(var item in query)
            {
                Console.WriteLine(item.amount);
            }
            Console.WriteLine("after query");

        }
        public void ShowOperations(string option)
        {
            Console.WriteLine("these are your operations:");
            if (option == "d")
            {
                var query2 = ListofOperations.Where(item => item.type == "d").OrderBy(item=>item.amount);
                foreach (var item in query2)
                {
                    Console.WriteLine(item.amount);
                }
            }
            else if (option == "w")
            {
                var query3 = ListofOperations.Where(item => item.type == "w").OrderBy(item => item.amount);
                foreach (var item in query3)
                {
                    Console.WriteLine(item.amount);
                }
            }
            else Console.WriteLine("invalid option");

            
        }
        public void ShowBalance() 
        {
           
            Console.WriteLine($"your current balance is {balance}") ;
        }
       



    }
}
