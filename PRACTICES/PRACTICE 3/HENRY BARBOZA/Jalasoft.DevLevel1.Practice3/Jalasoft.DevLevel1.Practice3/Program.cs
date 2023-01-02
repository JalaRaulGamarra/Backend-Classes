using Jalasoft.DevLevel1.Practice3;

BookManager<Book> bookManager = new BookManager<Book>();

Comic comic = new Comic(10, "Comic One", "Author", "Genre", "English");
Book comic2 = new Comic(20, "Comic Two", "Author", "Genre", "Spanish");
Essay essay = new Essay(30, "Essay One", "Author", "Genre", "Portuguese");
Book essay2 = new Essay(30, "Essay Two", "Author", "Genre", "French");
Novel novel = new Novel(40, "Novel One", "Author", "Genre", "English");

Console.WriteLine("     Book Request System\n     ");
// Add book
Console.WriteLine("Adding new books");
bookManager.AddBook(comic);
bookManager.AddBook(comic2);
bookManager.AddBook(essay);
bookManager.AddBook(essay2);
bookManager.AddBook(novel);
bookManager.ListBooks();

// Remove book
Console.WriteLine("\nRemoving books");
bookManager.RemoveBook(comic2);
bookManager.RemoveBook(essay2);
bookManager.ListBooks();

// Lend book
Console.WriteLine("\nLending books");
bookManager.LendBook(comic, "Pepe");
// Lending unavailable book
bookManager.LendBook(comic, "Ronaldo");
bookManager.LendBook(novel, "Messi");

// List book
Console.WriteLine("\nListing books");
bookManager.ListBooks();

