namespace Test_Book_Request
{
    public class Essay: TextBook

    {

        public Essay(string author, string name, string libraryCode, string genre, string language, string lenderName, double priceOfPurchase, string iSBN) : base(author, name, libraryCode, genre, language, lenderName, priceOfPurchase, iSBN) { }
    }
}