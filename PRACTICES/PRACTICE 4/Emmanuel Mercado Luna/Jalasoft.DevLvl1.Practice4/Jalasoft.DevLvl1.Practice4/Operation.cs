using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1.Practice4
{
    public class Operation
    {
        public int Amount { get; set; }
        public OperationTypes Type { get; set; }
        public string? Reference { get; set; }

        public Operation(int amount, OperationTypes type, string comment) 
        {
            Amount = amount;
            Type = type;
            Reference = comment;
        }
    }
}
