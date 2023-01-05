using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LibraryManager
    {
        public List<Book> bookList;

        public LibraryManager()
        {
            //book solo para pruebas
            Book tBook = new Book
            {
                Name = "name",
                Author = "Author",
                LibraryCode = 55555,
                Genre = "Novels",
                Language = "eng",
                Status = true,
                LenderName = "",
                PriceOfPurchase = 20,
                ISBNNumber = "55555",

            };

            this.bookList = new List<Book>
            {
                tBook
            };
        }

        public void AddBook(Book book)
        {
            if (!VerifyBookIfExist(book.ISBNNumber))
            {
                bookList.Add(book);

            }
            else {
                throw new Exception("Exist");
            }
        }

        public void RemoveBook(string isbnNumber)
        {
            Book fullBook = GetBook(isbnNumber);
            bookList.Remove(fullBook);
        }

        public Book GetBook(string isbnNumber)
        {
            Book book = new();

            foreach (Book b in this.bookList)
            {
                if (b.ISBNNumber == isbnNumber)
                {
                    book = b;
                }
            }
            return book;
        }

        public void LendABook(Book book)
        {
            Book fullBook = GetBook(book.ISBNNumber);
            fullBook.Status = book.Status;
            fullBook.LenderName = book.LenderName;
        }

        public void ReturnBook(Book book)
        {
            Book fullBook = GetBook(book.ISBNNumber);
            fullBook.Status = !book.Status;
            fullBook.LenderName = string.Empty;
        }

        public bool VerifyBookIfExist(string isbnNumber)
        {
            bool status = false;

            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].ISBNNumber == isbnNumber)
                {
                    status = true;
                }
            }
            return status;
        }

        public bool VerifyBookIfAvailable(string isbnNumber)
        {
            bool status = false;

            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].ISBNNumber == isbnNumber && bookList[i].Status)
                {
                    status = true;
                }
            }
            return status;
        }

        public void ShowBookList()
        {
            //string titles = "";

            //PropertyInfo[] lst = typeof(Book).GetProperties();

            //foreach (PropertyInfo oProperty in lst)
            //{
            //    string NombreAtributo = oProperty.Name;
            //    titles += NombreAtributo + "            ";
            //    Console.WriteLine("El atributo " + NombreAtributo );
            //}

            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Status)
                {
                    Console.WriteLine(bookList[i].Name + bookList[i].Author + bookList[i].Genre + bookList[i].ISBNNumber);
                }
            };
            //Console.WriteLine("titlees");
            //Console.WriteLine(titles);
        }
        public void ShowBookList2(Book book)
        {
            Book oPersona = book;
            PropertyInfo[] lst = typeof(Book).GetProperties();

            foreach (PropertyInfo oProperty in lst)
            {
                string NombreAtributo = oProperty.Name;
                string NombreAtributo2 = oProperty.GetValue(oPersona).ToString();
                Console.WriteLine("El atributo " + NombreAtributo + " tiene el valor: " + NombreAtributo2 + " type  ");
            }
        }
    }
}
