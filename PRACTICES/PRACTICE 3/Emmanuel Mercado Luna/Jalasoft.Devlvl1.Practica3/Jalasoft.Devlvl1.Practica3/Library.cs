using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica3
{
    internal class Library
    {
        public List<Book> Booklist;
        public ushort Code;
        public Library()
        {
            Booklist = new List<Book>();
            Code = 1110;
        }

        public void ShowBooks()
        {
            Console.WriteLine($"Book name   |   Author   |   Language    |   Code");
            foreach (Book book in Booklist)
            {
                Console.WriteLine($"{book.Name}     |   {book.Author}   |   {book.Language}     |   {book.LibraryCode}");

            }
        }
    }
}
