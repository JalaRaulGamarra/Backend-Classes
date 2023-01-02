using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRequestSystem
{
    public class BookManager: Book
    {
        private List<Novel> novels = new List<Novel>();
        private List<Essay> essays = new List<Essay>();
        private List<Comic> comics = new List<Comic>();

        

        public void LendBook(int libcode)
        {
            var result = new List<Book>(novels.Count + essays.Count + comics.Count);
            result.AddRange(novels);
            result.AddRange(essays);
            result.AddRange(comics);

                foreach (var item in result)
                {
                    if (item.LibraryCode == libcode)
                    {
                        if(item.Status == "Available")
                        {
                            Console.WriteLine("Enter the lender name");
                            string lenderName = Console.ReadLine();
                            item.LenderName = lenderName;
                            item.Status = "Unavailable";
                            Console.WriteLine("*****Loan Registered******");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("*******Not available******");
                        break;
                        }
                        
                    }
                    else {
                        Console.WriteLine("Lib code doesn't exist!!!");
                        break;
                    }
                }
            

        }

        //public void LendBook(Book book, string lenderName)
        //{
        //    if (book.Status == "Available")
        //    {
        //        book.LenderName = lenderName;
        //        book.Status = "Unavailable";
        //        Console.WriteLine("Loan Registered");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not available");
        //    }
        //}


        public void AddBook(Book book, int type)
        {
            if (type==1)
            {
                novels.Add((Novel)book);
            }
            else if (type==2)
            {
                essays.Add((Essay)book);
            }
            else if (type==3)
            {
                comics.Add((Comic)book);
            }
            //Console.WriteLine("**** Book Added ******");
        }

        public void RemoveBook(int libcode, string type)
        {
            if (type == "a")
            {
                int index = novels.FindIndex(a => a.LibraryCode == libcode);
                novels.RemoveAt(index);
            }
            else if (type == "b")
            {
                int index = essays.FindIndex(a => a.LibraryCode == libcode);
                essays.RemoveAt(index);
            }
            else if(type == "c")
            {
                int index = comics.FindIndex(a => a.LibraryCode == libcode);
                comics.RemoveAt(index);
            }
            Console.WriteLine("**** Book Removed ******");
            
        }

        //public void RemoveBook(Book book, int type)
        //{
        //    if (type == 1)
        //    {
        //        novels.Remove((Novel)book);
        //    }
        //    else if (type == 2)
        //    {
        //        essays.Remove((Essay)book);
        //    }
        //    else if (type == 3)
        //    {
        //        comics.Remove((Comic)book);
        //    }
        //}

        public void ShowBooks(string type)
        {
            if (type=="a")
            {
                foreach (var item in novels)
                {
                    Console.WriteLine("-Name:" + item.Name + " /Author:" + item.Author + " /Lib Code:" + item.LibraryCode + " /Status:" + item.Status);
                }
            }else if (type == "b")
            {
                foreach (var item in essays)
                {
                    Console.WriteLine("-Name:" + item.Name + " /Author:" + item.Author + " /Lib Code:" + item.LibraryCode + " /Status:" + item.Status);
                }
            }else if(type == "c")
            {
                foreach (var item in comics)
                {
                    Console.WriteLine("-Name:" + item.Name + " /Author:" + item.Author + " /Lib Code:" + item.LibraryCode + " /Status:" + item.Status);
                }
            }
            
        }

    }


}
