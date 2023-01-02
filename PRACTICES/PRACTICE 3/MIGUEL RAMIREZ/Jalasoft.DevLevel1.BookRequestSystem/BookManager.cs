using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.BookRequestSystem
{
    public class BookManager<TBook> where TBook : Book
    {
        private List<TBook> novels = new List<TBook>();
        private List<TBook> essays = new List<TBook>();
        private List<TBook> comics = new List<TBook>();

        public void LendBook(TBook book, string lenderName)
        {
            if (book.Status != "Available")
            {
                throw new Exception("This book is not available to be lent.");
            }
            book.Status = "Unavailable";
            book.LenderName = lenderName;
        }

        private void AddBookToList(TBook book, List<TBook> list)
        {
            if (list.Contains(book))
            {
                throw new Exception("This book is already in the list.");
            }
            list.Add(book);
        }

        private void RemoveBookFromList(TBook book, List<TBook> list)
        {
            if (!list.Contains(book))
            {
                throw new Exception("This book is not in the list.");
            }
            list.Remove(book);
        }

        public void AddBook(TBook book)
        {
            switch (book)
            {
                case Novel:
                    AddBookToList(book, novels);
                    break;
                case Essay:
                    AddBookToList(book, essays);
                    break;
                case Comic:
                    AddBookToList(book, comics);
                    break;
                default:
                    throw new Exception("Invalid book type");
            }
        }

        public void RemoveBook(TBook book)
        {
            switch (book)
            {
                case Novel:
                    RemoveBookFromList(book, novels);
                    break;
                case Essay:
                    RemoveBookFromList(book, essays);
                    break;
                case Comic:
                    RemoveBookFromList(book, comics);
                    break;
                default:
                    throw new Exception("Invalid book type");
            }
        }

        public List<TBook> GetBooks(BookType bookType)
        {
            switch (bookType)
            {
                case BookType.Novel:
                    return novels;
                case BookType.Essay:
                    return essays;
                case BookType.Comic:
                    return comics;
                default:
                    throw new Exception("Invalid book type");
            }
        }

        public void ReturnBook(TBook book)
        {
            book.Status = "Available";
            book.LenderName = string.Empty;
        }
    }
}
