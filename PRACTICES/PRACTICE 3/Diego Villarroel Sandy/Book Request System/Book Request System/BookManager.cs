using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Request_System
{
    public class BookManager <TLibrary>
        where TLibrary : Books
    {
        
        List<Novel> novels=new List<Novel>();
        List<Comic> comics = new List<Comic>();
        List<Essay> essays= new List<Essay>();
        public void LendBook(Books bookToLend, string lName) 
        {
            bookToLend.lendername=lName;
            if (bookToLend.status == true)
            { 
                Console.WriteLine($"Lended Book: {bookToLend.name}\n Author: {bookToLend.author}\nLibrary Code: {bookToLend.libraryCode}\n Lender Name: {bookToLend.lendername}");
                bookToLend.status= false;
            }
            else { Console.WriteLine("Book Unavailable"); }

        }
        public void AddBook(Books bookToAdd)
        {
            if (bookToAdd.type == "novel")
            {
               novels.Add((Novel)bookToAdd);
            }
            else if (bookToAdd.type == "comic")
            {
                comics.Add((Comic)bookToAdd);
            }
            else if (bookToAdd.type == "comic")
            {
                essays.Add((Essay)bookToAdd);
            }
            Console.WriteLine("Enter the title");
            bookToAdd.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter the author's name");
            bookToAdd.author = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter the library code");
            bookToAdd.libraryCode=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the genre of the book");
            bookToAdd.genre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter the book Language");
            bookToAdd.language = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter the purchase price of the book");
            bookToAdd.purchasePrice=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the isbn number");
            bookToAdd.isbnNumber=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Book added to its respective library");
        }
        public void PrintNovels()
        {
            foreach (Novel el in novels)
            {
                Console.WriteLine(el.name);
            } 
        }
        public void RemoveBook(Books bookToRemove) 
        {
            if (bookToRemove.type == "novel")
            {
                novels.Remove((Novel)bookToRemove);
            }
            else if (bookToRemove.type == "comic")
            {
                comics.Remove((Comic)bookToRemove);
            }
            else if (bookToRemove.type == "comic")
            {
                essays.Remove((Essay)bookToRemove);
            }

        }
    }
}
