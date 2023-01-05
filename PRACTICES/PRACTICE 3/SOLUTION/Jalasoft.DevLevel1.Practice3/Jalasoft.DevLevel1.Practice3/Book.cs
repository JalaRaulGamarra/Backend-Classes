using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice3
{
    public abstract class Book
    {
        public string Author { get; set; }
        internal string Name { get; set; }
        protected int LibraryCode { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public string Language { get; set; }
        public bool Available { get; set; }
        public string LenderName { get; set; }
        protected int PriceOfPurchase { get; set; }
        public int ISBN { get; set; }
    }
}
