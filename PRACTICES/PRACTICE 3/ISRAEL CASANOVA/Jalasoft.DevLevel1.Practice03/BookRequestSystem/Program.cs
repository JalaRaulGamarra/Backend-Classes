using BookRequestSystem;
using System.Diagnostics;

BookManager bookManager = new BookManager();

Novel novel1 = new Novel
{
    Author = "Jane Austen",
    Name = "Pride and Prejudice",
    Status = "Available",
    LibraryCode = 123,
    Language = "EN",
    PurchasePrice = 45.50,
    ISBN = 471298382
};

Novel novel2 = new Novel
{
    Author = "Juans",
    Name = "Other",
    Status = "Available",
    LibraryCode = 2020,
    Language = "EN",
    PurchasePrice = 55.50,
    ISBN = 21129122
};

Essay essay1 = new Essay()
{
    Author = "Chaplin",
    Name = "Funny",
    Status = "Available",
    LibraryCode = 456,
    Language = "ES",
    PurchasePrice = 100.70,
    ISBN = 98821434
};


Comic comic1 = new Comic
{
    Author = "Charles Dickens",
    Name = "Great Expectations",
    Status = "Available",
    LibraryCode = 789,
    Language = "ES",
    PurchasePrice = 90,
    ISBN = 889837213
};


bookManager.AddBook(novel1, 1);
bookManager.AddBook(novel2, 1);
bookManager.AddBook(essay1, 2);
bookManager.AddBook(comic1, 3);



/////////////////////////////////////////////
///
Console.WriteLine("SELECT A GNRE a): Novels b) Essays c) Comics ");
string bookGnre = Console.ReadLine();
Console.WriteLine("----------LIST---------------");
bookManager.ShowBooks(bookGnre);

while (true)
{
    Console.WriteLine("----------Choose an Option---------------");
    Console.WriteLine("1: Lend a Book ");
    Console.WriteLine("2: Add a Book");
    Console.WriteLine("3: Remove a Book");
    Console.WriteLine("4: List Books");
    Console.WriteLine("5: EXIT");
    Console.WriteLine("-----------------------------------");
    int userInput = int.Parse(Console.ReadLine());

    if (userInput == 1)
    {
        Console.WriteLine("Enter the library code to book loan");
        int libraryCode  = Int32.Parse(Console.ReadLine());
        //bookManager.LendBook(novel1);
        bookManager.LendBook(libraryCode);
    }
    else if (userInput == 2)
    {
        Console.WriteLine("Enter the author of the book:");
        string author = Console.ReadLine();
        Console.WriteLine("Enter the name of the book:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the library code of the book:");
        int libraryCode = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the language of the book:");
        string language = Console.ReadLine();
        Console.WriteLine("Enter the Purchase price of the book:");
        double pricePurchase = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ISBN of the book:");
        int ISBN = int.Parse(Console.ReadLine());


        var index = bookGnre == "a" ? 1 : bookGnre == "b" ? 2 : 3;
        if (bookGnre == "a")
        {
            bookManager.AddBook(new Novel
            {
                Author = author,
                Name = name,
                Status = "Available",
                LibraryCode = libraryCode,
                Language = language,
                PurchasePrice = pricePurchase,
                ISBN = ISBN
            }, index);
        }else if(bookGnre == "b")
        {
            bookManager.AddBook(new Essay
            {
                Author = author,
                Name = name,
                Status = "Available",
                LibraryCode = libraryCode,
                Language = language,
                PurchasePrice = pricePurchase,
                ISBN = ISBN
            }, index);
        }else if (bookGnre == "c")
        {
            bookManager.AddBook(new Comic
            {
                Author = author,
                Name = name,
                Status = "Available",
                LibraryCode = libraryCode,
                Language = language,
                PurchasePrice = pricePurchase,
                ISBN = ISBN
            }, index);
        }
        
            
    }
    else if (userInput == 3)
    {
        Console.WriteLine("Enter the library code to remove:");
        int libraryCode = int.Parse(Console.ReadLine());
        bookManager.RemoveBook(libraryCode, bookGnre);
    }
    else if(userInput == 4)
    {
        Console.WriteLine("SELECT A GNRE a): Novels b) Essays c) Comics ");
        string bookGnre2 = Console.ReadLine();
        Console.WriteLine("----------LIST---------------");
        bookManager.ShowBooks(bookGnre2);
    }
    else if(userInput == 5)
    {
        break;
    }
    

}






