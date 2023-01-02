using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    internal class BookManager
    {
        private List<Book> novels = new List<Book>();
        private List<Book> essays = new List<Book>();
        private List<Book> comics = new List<Book>();

        public void AddBook(Book book)
        {
            if (book.GetType() == typeof(Novel)) novels.Add(book);
            else if (book.GetType() == typeof(Essay)) essays.Add(book);
            else if (book.GetType() == typeof(Comic)) comics.Add(book);
            book.Available = true;
            book.LibraryCode = Book.LibraryCodeAsigner.ToString();
            Book.LibraryCodeAsigner += 1;
            book.AddBookInfo();
        }
        public void RemoveBook(Book book)
        {
            if (book.GetType() == typeof(Novel)) novels.Remove(book);
            else if (book.GetType() == typeof(Essay)) essays.Remove(book);
            else if (book.GetType() == typeof(Comic)) comics.Remove(book);
            book.Available = false;
            book.RemoveInfo();
        }
        public void LendBook(Book book, string lenderName)
        {
            if (book.Available)
            {
                book.Available = false;
                book.LenderName = lenderName;
                book.LendInfo();
            }
            else Console.WriteLine("the book is not available");
        }
        public void ReturnBook(Book book)
        {
            book.Available = true;
            book.LenderName = null;
            book.ReturnInfo();
        }
    }
}
