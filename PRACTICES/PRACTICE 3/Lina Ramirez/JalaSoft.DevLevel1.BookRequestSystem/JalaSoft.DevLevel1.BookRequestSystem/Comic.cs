using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoft.DevLevel1.BookRequestSystem
{
    internal class Comic: Book
    {
        public Comic(string author, string name, string genre, string languaje, int ISBN) 
        {
            Author = author;
            Name = name;
            Genre = genre;
            Language = languaje;
            this.ISBN = ISBN;
        }

    }
}
