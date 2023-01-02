using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.BookRequestSystem
{
    public class Novel : Book
    {
        public Novel(string author, string name, string libraryCode, Genre genre, string language, string status, string lenderName, double priceOfPurchase, string isbn)
        {
            Author = author;
            Name = name;
            LibraryCode = libraryCode;
            Genre = genre;
            Language = language;
            Status = status;
            LenderName = lenderName;
            PriceOfPurchase = priceOfPurchase;
            ISBN = isbn;
        }
    }
}
