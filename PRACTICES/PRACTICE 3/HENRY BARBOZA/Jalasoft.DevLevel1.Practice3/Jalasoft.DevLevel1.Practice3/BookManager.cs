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
        public List<TBook> ComicList = new List<TBook>();
        public List<TBook> EssayList = new List<TBook>();
        public List<TBook> NovelList = new List<TBook>();

        public void AddBook(TBook book)
        {
            Type type = book.GetType();
            if (type.Equals(typeof(Comic))) {
                ComicList.Add(book);
            } 
            else if (type.Equals(typeof(Essay)))
            {
                EssayList.Add(book);
            } 
            else if (type.Equals(typeof(Novel)))
            {
                NovelList.Add(book);
            }
        }
        public void RemoveBook(TBook book)
        {
            Type type = book.GetType();
            if (type.Equals(typeof(Comic)))
            {
                ComicList.Remove(book);
            }
            else if (type.Equals(typeof(Essay)))
            {
                EssayList.Remove(book);
            }
            else if (type.Equals(typeof(Novel)))
            {
                NovelList.Remove(book);
            }
        }
        public void LendBook(TBook book, string userName)
        {
            book.ChangeStatus(userName);
        }
        public void ListBooks()
        {
            int index = 0;
            foreach (TBook book in ComicList)
            {
                index++;
                Console.WriteLine(index + ". Name: " + book.Name + " Status: " + (book.Status ? "Unavailable" + " Lender Name: " + book.LenderName : "Available"));
            }
            foreach (TBook book in EssayList)
            {
                index++;
                Console.WriteLine(index + ". Name: " + book.Name + " Status: " + (book.Status ? "Unavailable" + " Lender Name: " + book.LenderName : "Available"));
            }
            foreach (TBook book in NovelList)
            {
                index++;
                Console.WriteLine(index + ". Name: " + book.Name + " Status: " + (book.Status ? "Unavailable" + " Lender Name: " + book.LenderName : "Available"));
            }
        }
    }
}
