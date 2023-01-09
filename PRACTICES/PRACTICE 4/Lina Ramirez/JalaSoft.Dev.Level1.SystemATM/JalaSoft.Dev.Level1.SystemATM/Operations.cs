using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoft.Dev.Level1.SystemATM
{
    public class Operations
    {
        public TypeOfTransaction Type { get; }
        public double AmountMoney { get; }

        public Operations(TypeOfTransaction type, double amountMoney)
        {
            Type = type;
            AmountMoney = amountMoney;
        }
    }
}
