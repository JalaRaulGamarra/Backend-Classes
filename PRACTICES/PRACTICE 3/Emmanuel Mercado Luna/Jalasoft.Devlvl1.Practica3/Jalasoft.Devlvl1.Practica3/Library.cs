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
        public Library()
        {
            Booklist = new List<Book>();
        }

        public void ShowBooks()
        {
            foreach (Book book in Booklist)
            {
                Console.WriteLine($"Book name: {book.Name}");
            }
        }
    }
}
