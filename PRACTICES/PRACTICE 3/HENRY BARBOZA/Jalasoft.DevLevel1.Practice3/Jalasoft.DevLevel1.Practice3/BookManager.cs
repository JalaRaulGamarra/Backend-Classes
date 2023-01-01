using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice3
{
    internal class BookManager<TBook>
        where TBook : Book
    {
        public List<TBook> BookList = new List<TBook>();

        public void AddBook(TBook book)
        {
            BookList.Add(book);
        }
        public void RemoveBook(TBook book)
        {
            BookList.Remove(book);
        }
        public void LendBook(TBook book, string userName)
        {
            book.ChangeStatus(userName);
        }
        public void ListBooks()
        {
            int index = 0;
            foreach (TBook book in BookList)
            {
                index++;
                Console.WriteLine(index + ". Name: " + book.Name + " Status: " + (book.Status ? "Unavailable" + " Lender Name: " + book.LenderName : "Available"));
            }
        }
    }
}
