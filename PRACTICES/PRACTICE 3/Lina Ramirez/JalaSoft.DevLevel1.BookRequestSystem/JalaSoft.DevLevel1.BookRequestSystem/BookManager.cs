using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoft.DevLevel1.BookRequestSystem
{
    internal class BookManager<TBook>
        where TBook : Book
    {
        public List<TBook> BookrequestList = new List<TBook>();

        public void AddBook(TBook book)
        {
            BookrequestList.Add(book);
        }

        public void BookLists()
        {
            int index = 0;
            foreach (TBook book in BookrequestList)
            {
                index++;
                Console.WriteLine(index + ". Name: " + book.Name + " Status: " + (book.Status ? "Unavailable" + " Lender Name: " + book.LenderName : "Available"));
            }
        }

        public void RemoveBook(TBook book)
        {
            BookrequestList.Remove(book);
        }

        public void LendBook(TBook book, string userName)
        {
            book.UpdateStatus(userName);
        }
       
    }
}
