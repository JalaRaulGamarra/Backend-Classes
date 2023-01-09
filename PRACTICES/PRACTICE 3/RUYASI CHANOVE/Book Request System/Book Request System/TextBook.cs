namespace Test_Book_Request
{
    public abstract class TextBook
    {
        public string Author { get; set; }
        internal string Name { get; set; }
        protected string LibrayCode { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Status { get; set; }
        public string ?LenderName { get; set; }
        protected double PriceOfPurchase{ get; set; }
        public string ISBN { get; set; }

        public TextBook(string author, string name, string librayCode, string genre, string language, string lenderName, double priceOfPurchase, string iSBN)
        {
            Author = author;
            Name = name;
            LibrayCode = librayCode;
            Genre = genre;
            Language = language;
            Status = "Avaiable";
            LenderName = lenderName;
            PriceOfPurchase = priceOfPurchase;
            ISBN = iSBN;
        }
        
    }
}