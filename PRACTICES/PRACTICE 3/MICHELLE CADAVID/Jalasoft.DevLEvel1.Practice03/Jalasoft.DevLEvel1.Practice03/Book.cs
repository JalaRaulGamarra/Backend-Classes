namespace Jalasoft.DevLEvel1.Practice03
{
    public class Book
    {
        public string author;
        public string name;
        public int libraryCode;
        public string genre;
        public string language;
        protected double purchasePrice;
        public string ISBNNumber;

        public string Status { get; set; }
        public string LenderName { get; set; }


        public Book(string auth, string nam, int libCode, string gnr, string lang, double purchPrc, string ISBN)
        {
            this.author = auth;
            this.name = nam;
            this.libraryCode = libCode;
            this.genre = gnr;
            this.language = lang;
            this.purchasePrice = purchPrc;
            this.ISBNNumber = ISBN;
            this.Status = "Available";
        }
    }
}