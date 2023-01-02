using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    public class Comic : Book
    {
        public Comic(string author, string name, int libraryCode, string genre, string language, string status, string lenderName, int priceOfPurchase, int isbnNumber) : base(author, name, libraryCode, genre, language, status, lenderName, priceOfPurchase, isbnNumber)
        {
        }
    }
}
