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
        internal ushort LibraryCode { get; set; }
        public readonly Genres Genre;
        public readonly Languages Language;
        internal bool Status { set; get; }
        internal LenderNames LenderName { set; get; }
        internal float PriceOfPurchase;
        public readonly long ISBN;
        public Book(string author, string name, Genres genre, Languages language, float priceOfPurchase, long ISBN)
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
