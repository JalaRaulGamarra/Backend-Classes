using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.BookRequestSystem
{
    public abstract class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string LibraryCode { get; set; }
        public Genre Genre { get; set; }
        public string Language { get; set; }
        public string Status { get; set; }
        public string LenderName { get; set; }
        public double PriceOfPurchase { get; set; }
        public string ISBN { get; set; }
    }
}
