using Jalasoft.Devlevel1.BookRequestSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        BookManager myBookManager = new BookManager();
        Book myComic1 = new Comic("Stan lee", "SpiderMan N1", "Action", "english", 1.99, "11111");
        Book myComic2 = new Comic("Stan lee", "SpiderMan N2", "Action", "english", 1.99, "22222");
        Book myNovel1 = new Novel("Alcides Arguedas", "Raza de Bronce", "National Romantic", "Spanish", 4.99, "33333");
        Book myEssay1 = new Essay("Ivan Fernandez", "Good Learning", "educational", "English", 0.00, "44444");
        
        myBookManager.AddBook(myComic1);
        myBookManager.AddBook(myComic2);
        myBookManager.LendBook(myComic1,"Ivan Fernandez");
        myBookManager.LendBook(myComic1, "Alejandro Espinoza");
        myBookManager.ReturnBook(myComic1);
        myBookManager.RemoveBook(myComic1);
        myBookManager.LendBook(myComic1, "Gaby");
        
        Console.WriteLine("--------------------*--------------------");
        myBookManager.AddBook(myNovel1);
        myBookManager.LendBook(myNovel1, "Eduardo Caba");
        myBookManager.ReturnBook(myNovel1);
        
        Console.WriteLine("--------------------*--------------------");
        myBookManager.AddBook(myEssay1);
        myBookManager.RemoveBook(myEssay1);
        myBookManager.LendBook(myEssay1, "Gaby");


    }
}