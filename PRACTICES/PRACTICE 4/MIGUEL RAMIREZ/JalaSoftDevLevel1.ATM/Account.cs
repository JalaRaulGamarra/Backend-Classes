using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoftDevLevel1.ATM
{
    public class Account : IAccount
    {
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }

        public List<Transaction> OperationsHistory;

        public Account(string accountNumber, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            OperationsHistory = new List<Transaction>();
        }

        public void Deposit(Transaction transaction)
        {
            if (transaction.Amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(transaction.Amount), "Transaction amount must be greater than zero.");
            }
            if (transaction.Amount % 10 != 0)
            {
                throw new InvalidDepositException();
            }

            AccountBalance += transaction.Amount;
            OperationsHistory.Add(transaction);
        }

        public void WithDraw(Transaction transaction)
        {
            if (transaction.Amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(transaction.Amount), "Transaction amount must be greater than zero.");
            }
            if (transaction.Amount > AccountBalance)
            {
                throw new NotEnoughMoneyException();
            }

            AccountBalance -= transaction.Amount;
            OperationsHistory.Add(transaction);
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Account Number : {AccountNumber} -  Current balance : {AccountBalance}");
        }

        public void ShowOperations(int? amount = null, OperationType? type = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            IEnumerable<Transaction> filteredOperations = OperationsHistory;
            if (amount.HasValue)
            {
                filteredOperations = OperationsHistory.Where(x => x.Amount >= amount);
            }
            else if (type.HasValue)
            {
                filteredOperations = OperationsHistory.Where(x => x.Type == type);
            }
            else if (startDate.HasValue && endDate.HasValue)
            {
                filteredOperations = filteredOperations.Where(x => x.Date >= startDate.Value && x.Date <= endDate.Value);
            }
            Console.WriteLine($"Account Number : {AccountNumber} -  Showing OperationsHistory");
            foreach (Transaction item in filteredOperations)
            {
                Console.WriteLine($"Transaction  : {(OperationType)item.Type} - " +
                    $"Ammount : {item.Amount} - Date : {item.Date}");
            }
        }

        public void ShowOperations()
        {
            Console.WriteLine($"Account Number : {AccountNumber} -  Showing OperationsHistory");
            foreach (Transaction item in OperationsHistory)
            {
                Console.WriteLine($"Transaction  : {(OperationType)item.Type} - " +
                    $"Ammount : {item.Amount} - Date : {item.Date}");
            }
        }
    }
}
