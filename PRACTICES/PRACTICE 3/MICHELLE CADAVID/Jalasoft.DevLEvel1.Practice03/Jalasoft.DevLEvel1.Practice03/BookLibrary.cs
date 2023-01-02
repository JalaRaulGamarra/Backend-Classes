using Jalasoft.DevLEvel1.Practice03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRequestSystem
{
    public class BookLibrary
    {
        public List<Book> Novels = new();
        public List<Book> Comics = new();
        public List<Book> Essays = new();

        public BookLibrary() 
        { 
        }

        public void DisplayMy(string booktype)
        {
            switch (booktype)
            {
                case "Novels":
                    Console.WriteLine("\nNovels:");
                    for (int i = 0; i < Novels.Count; i++)
                    {
                        Console.WriteLine($"{Novels[i].name}, Status: {Novels[i].Status}");
                    }
                    break;
                case "Comics":
                    Console.WriteLine("\nComics:");
                    for (int i = 0; i < Comics.Count; i++)
                    {
                        Console.WriteLine($"{Comics[i].name}, Status: {Comics[i].Status}");
                    }
                    break;
                case "Essays":
                    Console.WriteLine("\nEssays:");
                    for (int i = 0; i < Essays.Count; i++)
                    {
                        Console.WriteLine($"{Essays[i].name}, Status: {Essays[i].Status}");
                    }
                    break;
            }
        }

    }
}
