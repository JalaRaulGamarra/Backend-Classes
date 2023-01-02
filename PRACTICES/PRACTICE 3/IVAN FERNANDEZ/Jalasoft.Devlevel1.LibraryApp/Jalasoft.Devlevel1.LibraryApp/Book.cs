using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    public abstract class Book
    {
        public readonly string Author;
        public readonly string Name;
        public string LibraryCode { get; set; }
        public readonly string Genre;
        public readonly string Languaje;
        public string Status { get; set; }
        public string? LenderName { get; set; }
        public readonly double PriceOfPurchase;
        public readonly string ISBNNumber;
        public bool Avalaible { get; set; }

        public Book(string author, string name, string libraryCode, string genre, string languaje, double priceOfPurchase, string iSBNNumber)
        {
            Author = author;
            Name = name;
            LibraryCode = libraryCode;
            Genre = genre;
            Languaje = languaje;
            Status = "new";
            LenderName = null;
            PriceOfPurchase = priceOfPurchase;
            ISBNNumber = iSBNNumber;
            Avalaible = true;
        }

        public abstract void LendInfo(); 

    }
}
