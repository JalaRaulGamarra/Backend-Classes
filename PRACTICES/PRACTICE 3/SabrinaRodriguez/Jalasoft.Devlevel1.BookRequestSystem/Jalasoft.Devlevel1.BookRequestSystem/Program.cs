using Jalasoft.Devlevel1.BookRequestSystem;

BookManager<Novel> novelManager = new BookManager<Novel>();
BookManager<Comic> comicManager = new BookManager<Comic>();
BookManager<Essay> essayManager = new BookManager<Essay>();

novelManager.AddBook(new Novel("Jorge Luis Borges", "Ficciones", 1, "Fantasy", "Spanish", "Available", "", 100, 123456789));
novelManager.AddBook(new Novel("Jorge Luis Borges", "El Aleph", 2, "Fantasy", "Spanish", "Available", "", 100, 123456789));
novelManager.AddBook(new Novel("Jorge Luis Borges", "El Jardin de senderos que se bifurcan", 3, "Fantasy", "Spanish", "Available", "", 100, 123456789));

comicManager.AddBook(new Comic("Deathtone", "The Walking Dead", 4, "Horror", "English", "Available", "", 100, 123456789));
comicManager.AddBook(new Comic("Sakura Kinoshita", "Naruto", 5, "Fantasy", "Japanese", "Available", "", 100, 123456789));
comicManager.AddBook(new Comic("Death note", "Death note", 6, "Horror", "Japanese", "Available", "", 100, 123456789));

essayManager.AddBook(new Essay("kurt Vonnegut", "Slaughterhouse Five", 7, "Horror", "English", "Available", "", 100, 123456789));
essayManager.AddBook(new Essay("kurt Vonnegut", "Cat's Cradle", 8, "Horror", "English", "Available", "", 100, 123456789));
essayManager.AddBook(new Essay("kurt Vonnegut", "Breakfast of Champions", 9, "Horror", "English", "Available", "", 100, 123456789));



//foreach (var novel in novelManager.GetBooks())
//{
//    Console.WriteLine(novel.name);
//}

//foreach (var comic in comicManager.GetBooks())
//{
//    Console.WriteLine(comic.name);
//}

//foreach (var essay in essayManager.GetBooks())
//{
//    Console.WriteLine(essay.name);
//}

//novelManager.LendBook(novelManager.GetBooks()[0], "Juan");


//foreach (var novel in novelManager.GetBooks())
//{
//    Console.WriteLine(novel.name);
//    Console.WriteLine(novel.status);
//    Console.WriteLine(novel.lenderName);
//}

novelManager.RemoveBook(novelManager.GetBooks()[0]);

foreach (var novel in novelManager.GetBooks())
{
    Console.WriteLine(novel.name);
    Console.WriteLine(novel.status);
    Console.WriteLine(novel.lenderName);
}