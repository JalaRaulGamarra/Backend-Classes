using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalasoftDevLevel1TerceraPractica
{
    internal class BookManager <TBook> where TBook : Book
    {
        private List<TBook> comics = new List<TBook>();
        private List<TBook> essays = new List<TBook>();
        private List<TBook> novels = new List<TBook>();
        public void lendBook(TBook book, string lenderName)
        {
            
            if (book.Status == true)
            {
                book.LenderName = lenderName;
                book.Status = false;
                Console.WriteLine("The book was successfully reserved");
            }
            else
            {
                Console.WriteLine("The chosen book is not available");
            }
        }
        public void addBook(TBook book)
        {
            if (book.GetType() == typeof(Comic))
            {
                comics.Add(book);
            }
            else if (book.GetType() == typeof(Essay))
            {
                essays.Add(book);
            }
            else if (book.GetType() == typeof(Novel))
            {
                novels.Add(book);
            }
        }
        public void removeBook(TBook book)
        {
            if (book.GetType() == typeof(Comic))
            {
                comics.Remove(book);
                Console.WriteLine($"The book {book.Name} of type comic was removed successfully");
            }
            else if (book.GetType() == typeof(Essay))
            {
                essays.Remove(book);
                Console.WriteLine($"The book {book.Name} of type essay was removed successfully");

            }
            else if (book.GetType() == typeof(Novel))
            {
                novels.Remove(book);
                Console.WriteLine($"The book {book.Name} of type novel was removed successfully");
            }
        }
    }
}
