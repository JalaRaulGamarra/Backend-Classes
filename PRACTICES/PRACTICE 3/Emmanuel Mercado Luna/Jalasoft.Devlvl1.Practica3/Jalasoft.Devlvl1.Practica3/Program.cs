using Jalasoft.Devlvl1.Practica3;

Library myLibrary = new Library();
BookManager jessica = new BookManager(myLibrary, "jessica");

Book book1 = new Book("Platon","Pesares","Acción","English",45,7812547896312);

jessica.Add(book1);


myLibrary.ShowBooks();