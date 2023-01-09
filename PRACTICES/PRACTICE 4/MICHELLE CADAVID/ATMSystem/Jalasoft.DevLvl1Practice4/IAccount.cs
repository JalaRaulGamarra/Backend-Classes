using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLvl1Practice4
{
    internal interface IAccount
    {
        int AccBalance { get; set; }
        List<KeyValuePair<string, int>> Operations { get;set; }
        internal void Deposit(int ammount) ;
        internal void WithDraw(int ammount) ;
        internal void ShowOperations(string operation) ;
        internal void ShowOperations(int ammount) ;
        internal void ShowBalance() ;

    }
}
