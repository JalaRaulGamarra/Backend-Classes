using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice4
{
    internal class Account: IAccount
    {
        private int AccountBalance;
        private int InitBalance;
        List<Operation> Operations = new List<Operation>();

        public Account(int initBalance)
        {
            this.AccountBalance = initBalance;
            this.InitBalance = initBalance;
        }
        public void Deposit(Operation op)
        {
            if (op.Transaction % 10 != 0)
            {
                throw new NoTenException("Error: The account can only receive multiples of 10");
            }
            this.AccountBalance += op.Transaction;
            Operations.Add(op);
        }

        public void WithDraw(Operation op)
        {
            if (op.Transaction > AccountBalance)
            {
                throw new NoMoneyException("Error: Not enough money in account");
            }
            else if (op.Transaction % 10 != 0)
            {
                throw new NoTenException("Error: The account can only deliver multiples of 10");
            }
            this.AccountBalance -= op.Transaction;
            Operations.Add(op);
        }

        public void ShowBalance()
        {
            Console.WriteLine("Current Balance:" + AccountBalance);   
        }

        public void ShowOperations(int Sendvalue)
        {
            var query = Operations.Where(item => item.Transaction >= Sendvalue);

            foreach (var item in query)
            {
                Console.WriteLine(" => " + item.TypeTransaction + " " + item.Transaction);
            }
        }

        public void ShowOperations()
        {
            Console.WriteLine("Init Balance:" + InitBalance);
            foreach (var item in Operations)
            {
                Console.WriteLine(" => " + item.TypeTransaction + " " + item.Transaction);
            }
            Console.WriteLine("Current Balance:" + AccountBalance);
        }


    }
}
