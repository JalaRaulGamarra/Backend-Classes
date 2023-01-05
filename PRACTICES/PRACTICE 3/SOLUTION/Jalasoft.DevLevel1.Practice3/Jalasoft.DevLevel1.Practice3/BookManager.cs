using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice3
{
    internal class BookManager
    {
        private List<Book> comics;
        private List<Book> essays;
        private List<Book> novels;
        public List<Book> Comics { get => comics; private set => comics = value; }
        public List<Book> Novels { get => novels; private set => novels = value; }
        public List<Book> Essays { get => essays; private set => essays = value; }

        public BookManager()
        {
            Comics = new List<Book>();
            Novels = new List<Book>();
            Essays = new List<Book>();
        }

        public string LendBook(Book book, string lenderName)
        {
            string message;
            if (typeof(Comic) == book.GetType())
            {
                int bookIndex = CheckBookExistence(Comics, book);
                message = LendBookIfAvailable(Comics, bookIndex, book.Name, lenderName);
            }
            else if (typeof(Novel) == book.GetType())
            {
                int bookIndex = CheckBookExistence(Novels, book);
                message = LendBookIfAvailable(Novels, bookIndex, book.Name, lenderName);
            }
            else
            {
                int bookIndex = CheckBookExistence(Essays, book);
                message = LendBookIfAvailable(Essays, bookIndex, book.Name, lenderName);
            }
            return message;
        }

        private int CheckBookExistence(List<Book> bookCollection, Book book)
        {
            int index = bookCollection.FindIndex(x => x == book);
            bool exists = index >= 0;
            return index;
        }

        private string LendBookIfAvailable(List<Book> bookCollection, int index, string bookName, string lenderName)
        {
            string message;
            if (bookCollection[index].Available)
            {
                bookCollection[index].Available = false;
                bookCollection[index].LenderName = lenderName;
                message = $"Book: {bookName} - lend succesful";
            }
            else
            {
                message = $"Book: {bookName} is not available";
            }

            return message;
        }

        public string AddBookToLibrary(Book book)
        {
            string returnMessage;
            if (typeof(Comic) == book.GetType())
            {
                returnMessage = AddBookToCollection(Comics, book);
            }
            else if (typeof(Novel) == book.GetType())
            {
                returnMessage = AddBookToCollection(Novels, book);
            }
            else
            {
                returnMessage = AddBookToCollection(Essays, book);
            }
            return returnMessage;
        }

        public string RemoveBookFromLibrary(Book book)
        {
            string returnMessage;
            if (typeof(Comic) == book.GetType())
            {
                returnMessage = RemoveBookFromCollection(Comics, book);
            }
            else if (typeof(Novel) == book.GetType())
            {
                returnMessage = RemoveBookFromCollection(Novels, book);
            }
            else
            {
                returnMessage = RemoveBookFromCollection(Essays, book);
            }
            return returnMessage;
        }

        private string RemoveBookFromCollection(List<Book> bookCollection, Book book)
        {
            string message;
            bool bookExists = bookCollection.Exists(x => x == book);
            if (bookExists)
            {
                bookCollection.Remove(book);
                message = $"Book {book.Name} removed correctly";
            }
            else
            {
                message = $"Book {book.Name} does not exist in library";
            }
            return message;
        }

        private string AddBookToCollection(List<Book> bookCollection, Book book)
        {
            string message;
            bool isAlreadyStored = bookCollection.Exists(x => x == book);
            if (!isAlreadyStored)
            {
                bookCollection.Add(book);
                message = $"Book {book.Name} stored correctly";
            }
            else
            {
                message = $"Book {book.Name} already exists";
            }
            return message;
        }
    }
}
