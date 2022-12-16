using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice1
{
    internal class Order
    {
        public string Customer { get; set; }
        public int OrderNumber { get; set; }
        public List<Dish> Dishes { get; set; }
        public List<Beverage> Beverages { get; set; }
        public PaymentMethods PaymentMethod { get; set; }

        public Order()
        {
            Dishes= new List<Dish>();
            Beverages= new List<Beverage>();
        }
    }
}
