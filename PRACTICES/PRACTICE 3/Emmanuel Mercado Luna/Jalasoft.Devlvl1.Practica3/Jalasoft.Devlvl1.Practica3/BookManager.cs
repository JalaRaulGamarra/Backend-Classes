using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlvl1.Practica3
{
    internal class BookManager
    {
        public Library MyLibrary;
        public string LenderName;
        public BookManager(Library library, string lenderName) {
            this.MyLibrary = library;
            this.LenderName = lenderName;
        }

        public void Lend(Book book)
        {            
            Console.WriteLine("Book Lended");
        }

        public void Add(Book book)
        {
            MyLibrary.Booklist.Add(book);
            Console.WriteLine("Book Added");
        }

        public void Remove(Book book)
        {
            Console.WriteLine("Book Removed");
        }

        public void Return() 
        {
            Console.WriteLine("Book Returned");
        }
    }
}
