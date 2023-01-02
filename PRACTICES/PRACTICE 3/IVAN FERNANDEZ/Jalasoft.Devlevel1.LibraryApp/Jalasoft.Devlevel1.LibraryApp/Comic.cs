using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    internal class Comic : Book
    {
        public Comic(string author, string name, string genre, string languaje, double priceOfPurchase, string iSBNNumber) : base(author, name, genre, languaje, priceOfPurchase, iSBNNumber)
        {
        }

        public override void AddBookInfo()
        {
            Console.WriteLine($"The Comic '{this.LibraryCode} - {this.Name}' was added at the library so now it is not Available");
        }
        public override void LendInfo()
        {
            Console.WriteLine($"The Comic '{this.LibraryCode} - {this.Name}' was lend to '{this.LenderName}' so now it is not Available");
        }
        public override void RemoveInfo()
        {
            Console.WriteLine($"The Comic '{this.LibraryCode} - {this.Name}' was removed from de library so now it is not Available");
        }
        public override void ReturnInfo()
        {
            Console.WriteLine($"The Comic '{this.LibraryCode} - {this.Name}' was returnd to library so it is now Available");
        }
    }
}
