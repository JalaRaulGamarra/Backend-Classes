using Jalasoft.Devlvl1.Practica3;

Library myLibrary = new Library();
BookManager manager1 = new BookManager(myLibrary, LenderNames.Jessica);

Book book1 = new Book("Platon","Pesares",Genres.Philosophy, Languages.English,48.99f,7812547896312);
Book book2 = new Book("Marco Aurelio", "Meditaciones", Genres.Philosophy, Languages.Spanish, 60f, 7812547896312);

manager1.Add(book1);
manager1.Add(book2);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
myLibrary.ShowBooks();
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
manager1.Lend(book1);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
manager1.Lend(book1);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
manager1.Return(book1);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
manager1.Remove(book1);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
myLibrary.ShowBooks();