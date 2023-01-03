using System.Collections;

namespace Test_Book_Request
{
    public class BookManager
    {
        public static List<Novel> Novels { set; get; } = new List<Novel>();
        public static List<Comic> Comics { set; get; } = new List<Comic>();
        public static List<Essay> Essays { set; get; } = new List<Essay>();
        
        public void Add(TextBook book)        {
            if(book.GetType() == typeof(Novel))
            {
                Novels.Add((Novel)book);
            }
            else if(book.GetType() == typeof(Comic))
            {
                Comics.Add((Comic)book);
            }
            else if(book.GetType() == typeof(Essay))
            {
                Essays.Add((Essay)book);
            }

        }
        

        public void Lend(TextBook book,string lenderName, string typeOfBook, string nameOfBook) 
        {
            if (book.Status == "Avaiable")
            {
                book.LenderName = lenderName;
                book.Status = "Unavaiable";
            }
            else
            {
                string e = "Book not Avaiable";
                throw new Exception(e);
            }
        }

        public void Remove(TextBook book, string name)
        {
            if (book.Name == name)
            {
                if (book.GetType() == typeof(Novel))
                {
                    Novels.Remove((Novel)book);
                }

                else if (book.GetType() == typeof(Comic))
                {
                    Comics.Remove((Comic)book);
                }
                else if (book.GetType() == typeof(Essay))
                {
                    Essays.Remove((Essay)book);
                }
            }
        }

        
    }
}

