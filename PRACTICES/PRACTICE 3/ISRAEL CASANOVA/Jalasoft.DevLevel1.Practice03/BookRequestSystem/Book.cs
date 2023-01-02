using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRequestSystem
{
    public abstract class Book
    {
        public string Author { get; protected internal set; }
        public string Name { get; protected internal set; }
        public string Status { get; internal  set; }
        public string LenderName { get; set; }
        public int LibraryCode { get; set; }


        public string Genre { get; protected internal set; }
        public string Language { get; protected internal set; }
        public double PurchasePrice { get; protected internal set; }
        public int ISBN { get; protected internal set; }
    }
}
