using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JalaSoft.DevLevel1.BookRequestSystem
{
    internal class Book
    {
        public bool status = true;
        public double pricePurchase;
        public int ISBN;

        public string Author { get; set; }
        public string Name { get; set; }
        public string LibraryCode { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public bool Status { get { return status; } }
        public string LenderName { get; set; }

        public void UpdateStatus(string lenderName)
        {
            if (status == true)
            {
                LenderName = lenderName;
            }
            else
            {
                Console.WriteLine("El libro no esta disponible en este momento");
            }
        }
    }
}
