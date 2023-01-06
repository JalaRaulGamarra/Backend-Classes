// See https://aka.ms/new-console-template for more information
using Jalasoft.DevLevel1.Practice3;
using System.Xml;

Essay essay = new Essay("essay 1") { Genre = "Math", Pages = 500, Author = "Vance", Language = "English", ISBN = 1 };
Essay essay1 = new Essay("essay 2") { Genre = "Politics", Pages = 320, Author = "Maxwell", Language = "English", ISBN = 2 };
Essay essay2 = new Essay("essay 3") { Genre = "History", Pages = 320, Author = "Donens", Language = "English", ISBN = 3 };
Comic comic = new Comic("comic 1");
BookManager library = new BookManager();
Console.WriteLine(library.AddBookToLibrary(essay));
Console.WriteLine(library.AddBookToLibrary(essay1));
Console.WriteLine(library.AddBookToLibrary(essay2));
Console.WriteLine(library.AddBookToLibrary(comic));
Console.WriteLine(library.LendBook(essay, "Dan"));
Console.WriteLine(library.LendBook(essay, "Doyle"));
Console.WriteLine(library.RemoveBookFromLibrary(comic));