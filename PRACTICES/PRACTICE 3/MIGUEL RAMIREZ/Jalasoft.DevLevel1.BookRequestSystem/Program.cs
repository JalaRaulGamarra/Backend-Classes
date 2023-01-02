using Jalasoft.DevLevel1.BookRequestSystem;

BookManager<Book> bookManager = new BookManager<Book>();
Novel novel = new Novel("John Doe", "The Great Gatsby", "1234", Genre.Fiction, "English", "Available", "", 10.0, "978-0-7475-3269-9");

bookManager.AddBook(novel);


List<Book> novels = bookManager.GetBooks(BookType.Novel);
foreach (Novel item in novels)
{
    Console.WriteLine($"Nombre: {item.Name} - Autor: {item.Author} - Estado: {item.Status}");
}

//prestamos libro
bookManager.LendBook(novel, "Miguel Ramirez");


//Intentamos prestar el libro de nuevo, lo que lanzaría una excepción
try
{
    bookManager.LendBook(novel, "John Doe");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//devolvemos el libro prestado
bookManager.ReturnBook(novel);
bookManager.RemoveBook(novel);