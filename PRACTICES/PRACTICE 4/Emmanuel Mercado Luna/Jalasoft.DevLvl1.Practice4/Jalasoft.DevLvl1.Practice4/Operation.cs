using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1.Practice4
{
    internal class Operation
    {
        public int Amount { get; set; }
        public OperationTypes Type { get; set; }
        public string? Comment { get; set; }

        public Operation(int amount, OperationTypes type, string comment) 
        {
            Amount = amount;
            Type = type;
            Comment = comment;
        }
    }
}
