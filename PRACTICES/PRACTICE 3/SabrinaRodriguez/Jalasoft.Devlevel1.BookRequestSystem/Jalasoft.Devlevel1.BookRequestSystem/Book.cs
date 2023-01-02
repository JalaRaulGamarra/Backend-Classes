using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    public class Book
    {
        public string author { get; set; }
        public string name { get; set; }
        public int libraryCode { get; set; }
        public string genre { get; set; }
        public string language { get; set; }
        public string status { get; set; }
        public string lenderName { get; set; }
        public int priceOfPurchase { get; set; }
        public int isbnNumber { get; set; }

        public Book(string author, string name, int libraryCode, string genre, string language, string status, string lenderName, int priceOfPurchase, int isbnNumber)
        {
            this.author = author;
            this.name = name;
            this.libraryCode = libraryCode;
            this.genre = genre;
            this.language = language;
            this.status = status;
            this.lenderName = lenderName;
            this.priceOfPurchase = priceOfPurchase;
            this.isbnNumber = isbnNumber;
        }
    }
}
