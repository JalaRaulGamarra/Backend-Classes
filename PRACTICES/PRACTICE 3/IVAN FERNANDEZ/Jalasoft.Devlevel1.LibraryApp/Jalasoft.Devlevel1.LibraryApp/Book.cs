using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    public abstract class Book
    {
        public static int LibraryCodeAsigner = 0;    

        public readonly string Author;
        public readonly string Name;
        public readonly string Genre;
        public readonly string Languaje;
        public readonly double PriceOfPurchase;
        public readonly string ISBNNumber;

        public string LibraryCode { get; set; }
        public string Status { get; set; }
        public string? LenderName { get; set; }
        public bool Available { get; set; }

        public Book(string author, string name, string genre, string languaje, double priceOfPurchase, string iSBNNumber)
        {
            Author = author;
            Name = name;
            Genre = genre;
            Languaje = languaje;
            Status = "new";
            LenderName = null;
            PriceOfPurchase = priceOfPurchase;
            ISBNNumber = iSBNNumber;
            Available = false;
        }

        public abstract void LendInfo();
        public abstract void RemoveInfo();
        public abstract void ReturnInfo();
        public abstract void AddBookInfo();

    }
}
