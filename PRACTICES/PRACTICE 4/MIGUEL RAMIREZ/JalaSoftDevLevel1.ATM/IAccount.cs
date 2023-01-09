using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoftDevLevel1.ATM
{
    public interface IAccount
    {
        void Deposit(Transaction transaction);
        void WithDraw(Transaction transaction);
        void ShowOperations(int? amount = null, OperationType? type = null, DateTime? startDate = null, DateTime? endDate = null);
        void ShowOperations();
        void ShowBalance();
    }
}
