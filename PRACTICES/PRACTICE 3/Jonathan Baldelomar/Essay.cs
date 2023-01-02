using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalasoftDevLevel1TerceraPractica
{
    internal class Essay : Book
    {
        public Essay(string author, string name, int libraryCode, string genre, string language, bool status, string lenderName, double priceOfPurchase, int iSBNNumber)
        {
            Author = author;
            Name = name;
            LibraryCode = libraryCode;
            Language = language;
            Status = status;
            LenderName = lenderName;
            PriceOfPurchase = priceOfPurchase;
            ISBNNumber = iSBNNumber;
        }
    }
}
