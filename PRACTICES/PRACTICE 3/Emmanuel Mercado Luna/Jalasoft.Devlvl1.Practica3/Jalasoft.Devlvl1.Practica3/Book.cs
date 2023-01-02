using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jalasoft.Devlvl1.Practica3
{
    internal class Book
    {
        public readonly string Author;
        public readonly string Name;
        public readonly ushort LibraryCode;
        public readonly string Genre;
        public readonly string Language;
        internal bool Status { set; get; }
        internal string? LenderName { set; get; }
        public readonly float PriceOfPurchase;
        public readonly long ISBN;
        public Book(string author, string name, string genre, string language, float priceOfPurchase, long ISBN)
        {
            Author = author;
            Name = name;
            Genre = genre;
            Language = language;
            PriceOfPurchase = priceOfPurchase;
            this.ISBN = ISBN;
            Status = true;
        }
    }
}
