using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Devlevel1.BookRequestSystem
{
    internal class BookManager
    {
        private List<Book> novels;
        private List<Book> essays;
        private List<Book> comics;

        public void AddBook(Book book)
        {
            switch (book.GetType().ToString())
            {
                case "Novel":
                    novels.Add(book); break;
                case "Essay":
                    essays.Add(book); break;
                case "Comic":
                    comics.Add(book); break;
                default:
                    break;
            }
            book.Avalaible = true;
        }
        public void RemoveBook(Book book)
        {
            switch (book.GetType().ToString())
            {
                case "Novel":
                    novels.Remove(book); break;
                case "Essay":
                    essays.Remove(book); break;
                case "Comic":
                    comics.Remove(book); break;
                default:
                    break;
            }
        }
        public void LendBook(Book book, string lenderName)
        {
            if (book.Avalaible)
            {
                book.Avalaible = false;
                book.LenderName = lenderName;
                book.LendInfo();
            }
            else Console.WriteLine("the book is not available");
        }
        public void returnBook(Book book)
        {
                book.Avalaible = true;
                book.LenderName = null;
                Console.WriteLine("the book was returned");
        }
    }
}
