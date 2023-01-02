// See https://aka.ms/new-console-template for more information
using JalaSoft.DevLevel1.BookRequestSystem;

Console.WriteLine("Hello, World!");

BookManager<Book> bookSytem = new BookManager<Book>();

Novel novel = new Novel("Gabriela Garcia Marquez", "No One Writes to the Colonel", "Short novel", "English", 1678);
Essay essay = new Essay("Antonio Monegal", "Como el aire que respiramos. El sentido de la cultura", "Essay", "Spanish", 1287);
Comic comic = new Comic("David Safier", "Maldito karma", "Comic", "spanish", 2898);
Book novel1 = new Novel("El principito", "Antoine de Saint", "Novel", "English", 8678);
Book essay1 = new Essay("Antonio Monegal", "Jorge Luis Borges", "Essay", "Spanish", 1787);
Book comic1 = new Comic("David Safier", "The Walking Dead", "Comic", "spanish", 2098);




bookSytem.AddBook(comic);
bookSytem.AddBook(essay);
bookSytem.AddBook(novel);
bookSytem.BookLists();

bookSytem.LendBook(novel, "Jose");
bookSytem.LendBook(essay, "Raul");
bookSytem.LendBook(comic, "Richard");
bookSytem.LendBook(novel, "Monica");


bookSytem.RemoveBook(comic);
bookSytem.RemoveBook(essay);
bookSytem.BookLists();