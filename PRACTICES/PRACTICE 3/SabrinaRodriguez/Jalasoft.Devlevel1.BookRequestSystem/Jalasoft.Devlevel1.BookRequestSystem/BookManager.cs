using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    public class BookManager<T> where T : Book
    {
        private List<T> books;

        public BookManager()
        {
            this.books = new List<T>();
        }

        public void AddBook(T book)
        {
            this.books.Add(book);
        }

        public void RemoveBook(T book)
        {
            this.books.Remove(book);
        }

        public List<T> GetBooks()
        {
            return this.books;
        }

        public void LendBook(T book, string lenderName)
        {
            if (book.status == "Available")
            {
                book.status = "Unavailable";
                book.lenderName = lenderName;
            }
        }
    }
}
