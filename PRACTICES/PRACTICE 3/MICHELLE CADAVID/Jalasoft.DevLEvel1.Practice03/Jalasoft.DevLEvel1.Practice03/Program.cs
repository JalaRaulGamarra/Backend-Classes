using BookRequestSystem;
using Jalasoft.DevLEvel1.Practice03;

//Create Library
BookLibrary coolBookLibrary = new BookLibrary();

//Create Books
var dreamsOfLove = new Novel("Michelle Cadavid", "Dreams of love", 12345, "Romance", "Spanish",500, "1-123-456");
var candyIsland = new Novel("Naruto Uzumaki", "Candy island", 56789, "Adventure", "English", 700, "2-123-456");
var batmanVsPinkColor = new Comic("Hello Kitty", "Batman vs Pink color", 101112, "Comedy", "English", 700, "3-123-456");
var supermanDancesBad = new Comic("Superman Hater", "Superman doesn't know how to dance", 131415, "philosophy", "German", 700, "4-123-456");
var catsBehavior = new Essay("Cat Lover", "Cats behavior, how they domesticated us", 161718, "Social Studies", "English", 700, "5-123-456");
var iLoveBread = new Essay("Brad Breader", "I Love bread", 161718, "Psichology", "English", 700, "7-123-456");

//Store Books (Add to the library)
BookManager.StoreBook(coolBookLibrary, dreamsOfLove);
BookManager.StoreBook(coolBookLibrary, candyIsland);
BookManager.StoreBook(coolBookLibrary, batmanVsPinkColor);
BookManager.StoreBook(coolBookLibrary, supermanDancesBad);
BookManager.StoreBook(coolBookLibrary, catsBehavior);
BookManager.StoreBook(coolBookLibrary, iLoveBread);
Console.WriteLine("Books stored!");


//Lend Book
BookManager.LendBook(coolBookLibrary, dreamsOfLove, "Maria");
BookManager.LendBook(coolBookLibrary, batmanVsPinkColor, "Jose");
BookManager.LendBook(coolBookLibrary, iLoveBread, "Maquiavelo");

//Show books
coolBookLibrary.DisplayMy("Novels");
coolBookLibrary.DisplayMy("Comics");
coolBookLibrary.DisplayMy("Essays");

//Remove books
BookManager.RemoveBook(coolBookLibrary, candyIsland);
BookManager.RemoveBook(coolBookLibrary, batmanVsPinkColor);

//Show books again
coolBookLibrary.DisplayMy("Novels");
coolBookLibrary.DisplayMy("Comics");
coolBookLibrary.DisplayMy("Essays");
