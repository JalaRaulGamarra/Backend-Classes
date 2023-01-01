using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice3
{
    public abstract class Book
    {
        protected int isbn;
        protected string libraryCode;
        protected bool status = false;
        protected double priceOfPurchase;
        public string Author { get; protected set; }
        public string Name { get; protected set; }
        public string Genre { get; protected set; }
        public string Language { get; protected set; }
        public string LenderName { get; protected set; }

        public bool Status
        {
            get
            {
                return status;
            }
        }
        public void ChangeStatus(string userName) 
        {
            if (this.status == false)
            {
                this.status = true;
                this.LenderName = userName;
            }
            else
            {
                Console.WriteLine("Book Unavailable");
            }
        }
    }
}
