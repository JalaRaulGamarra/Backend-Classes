using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice3
{
    internal class Novel : Book
    {
        public Novel(int ISBN, string name, string author, string genre, string language)
        {
            this.isbn = ISBN;
            Name = name;
            Author = author;
            Genre = genre;
            Language = language;
        }
    }
}
