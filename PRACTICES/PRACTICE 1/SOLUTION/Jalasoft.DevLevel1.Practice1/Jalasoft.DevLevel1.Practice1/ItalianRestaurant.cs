using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice1
{
    internal struct ItalianRestaurant
    {
        public int lastOrder;
        public Queue<Order> orders;

        public ItalianRestaurant()
        {
            lastOrder= 0;
            orders = new Queue<Order>();
        }
        public void ReceiveOrder(Order order)
        {
            lastOrder++;
            order.OrderNumber = lastOrder;
            orders.Enqueue(order);
            if (orders.Count == 5)
            {
                PrepareOrders();
            }
        }

        public void PrepareOrders()
        {
            while (orders.Count > 0)
            {
                var order = orders.Dequeue();
                var totalPrice = GetTotalPrice(order);
                var paymentMethodName = Enum.GetName(typeof(PaymentMethods), order.PaymentMethod);
                Console.WriteLine($"Delivering Order {order.OrderNumber} - Customer {order.Customer}");
                foreach (var dish in order.Dishes)
                {
                    var dishName = Enum.GetName(typeof(DishesMenu), dish.Name);
                    Console.WriteLine($"{dish.DishCount} {dishName}(s)");
                }
                foreach (var beverage in order.Beverages)
                {
                    var beverageName = Enum.GetName(typeof(BeveragesMenu), beverage.Name);
                    Console.WriteLine($"{beverage.BeverageCount} {beverageName}(s)");
                }
                Console.WriteLine($"Total cost: {totalPrice} / payment method: {paymentMethodName}");
            }
        }

        public double GetTotalPrice(Order order)
        {
            double totalPrice = 0;
            foreach (var dish in order.Dishes)
            {
                totalPrice += dish.TotalPrice;
            }
            foreach (var beverage in order.Beverages)
            {
                totalPrice += beverage.TotalPrice;
            }
            return totalPrice;
        }
    }
}
