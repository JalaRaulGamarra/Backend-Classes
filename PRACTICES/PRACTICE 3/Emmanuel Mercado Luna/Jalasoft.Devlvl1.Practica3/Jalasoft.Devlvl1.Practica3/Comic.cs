using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica3
{
    internal class Comic : Book
    {
        public Comic(string author, string name, Genres genre, Languages language, float priceOfPurchase, long ISBN) : base(author, name, genre, language, priceOfPurchase, ISBN)
        {
            Status = true;
        }
    }
}
