using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalasoftDevLevel1TerceraPractica
{
    internal class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int LibraryCode { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public bool Status { get; set; }
        public string LenderName { get; set; }
        public double PriceOfPurchase { get; set; }
        public int ISBNNumber { get; set; }
    }
}
