using BookRequestSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLEvel1.Practice03
{
    public static class BookManager
        
    {
        public static List<Book> AllBooks = new List<Book>();
        public static void StoreBook<TBook>(BookLibrary myLib,  TBook myBook) where TBook : Book
        {

            if (myBook.GetType() == typeof(Novel))
            {
                myLib.Novels.Add(myBook);
            } else if (myBook.GetType() == typeof(Comic))
            {
                myLib.Comics.Add(myBook);
            } else if (myBook.GetType() == typeof(Essay))
            {
                myLib.Essays.Add(myBook);
            }
        }

        public static void LendBook<TBook>(BookLibrary myLib, TBook myBook, string lender) where TBook : Book
        {
            if (myBook.Status == "Available")
            {
                myBook.LenderName = lender;
                myBook.Status = "Unavailable";
                Console.WriteLine($"\n{myBook.name} Has been lended to {myBook.LenderName}, Current status {myBook.Status}");
            }
            else
            {
                string err = "Book is not available";
                throw new Exception(err);
            }

        }

        public static void RemoveBook<TBook>(BookLibrary myLib,TBook myBook) where TBook : Book
        {
            if (myBook.GetType() == typeof(Novel))
            {
                myLib.Novels.Remove(myBook);
                Console.WriteLine($"\n{myBook.name} Has been removed from the library");
            }
            else if (myBook.GetType() == typeof(Comic))
            {
                myLib.Comics.Remove(myBook);
                Console.WriteLine($"\n{myBook.name} Has been removed from the library");
            }
            else if (myBook.GetType() == typeof(Essay))
            {
                myLib.Essays.Remove(myBook);
                Console.WriteLine($"\n{myBook.name} Has been removed from the library");
            }
        }


    }
}
