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
        public LenderNames LenderName;
        public BookManager(Library library, LenderNames lenderName) {
            this.MyLibrary = library;
            this.LenderName = lenderName;
        }


        public void Add(Book book)
        {
            book.LibraryCode = MyLibrary.Code;
            MyLibrary.Booklist.Add(book);
            MyLibrary.Code++;
            Console.WriteLine($"Book Added: \"{book.Name}\" with a Library code:{book.LibraryCode}");
        }
        public void Lend(Book book)
        {
            if (book.Status)
            {
                book.Status = false;
                Console.WriteLine($"Book \"{book.Name}\" was lended by manager {Enum.GetName(typeof(LenderNames), this.LenderName)}");
            }
            else
            {
                Console.WriteLine($"The book \"{book.Name}\" was already lended, try with another, please");
            }
        }
        public void Return(Book book) 
        {
            book.Status = true;
            Console.WriteLine($"Book \"{book.Name}\" was returned to manager {Enum.GetName(typeof(LenderNames), this.LenderName)}");
        }

        public void Remove(Book book)
        {
            var selectedBook = MyLibrary.Booklist.Find(x => x.LibraryCode == book.LibraryCode);
            MyLibrary.Booklist.Remove(selectedBook);            
            Console.WriteLine($"Book \"{book.Name}\" was removed.");
        }

    }
}
