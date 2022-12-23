// See https://aka.ms/new-console-template for more information
using Jalasoft.DevLevel1.Practice1;

int orderNumber = 1;
var italianRestaurant = new ItalianRestaurant();
//order 1
var order = new Order();
order.Customer = "Jhon";
order.PaymentMethod = PaymentMethods.cash;
order.Dishes = new List<Dish> { new Dish(DishesMenu.Lasagna, 2) };
order.Beverages = new List<Beverage> { new Beverage(BeveragesMenu.Beer, 2) };
italianRestaurant.ReceiveOrder(order);
//order 2
var order2 = new Order();
order2.Customer = "Bob";
order.PaymentMethod = PaymentMethods.cash;
order2.Dishes = new List<Dish> { new Dish(DishesMenu.Pizza, 1) };
order2.Beverages = new List<Beverage> { new Beverage(BeveragesMenu.Wine, 2) };
italianRestaurant.ReceiveOrder(order2);
//order 3
var order3 = new Order();
order3.Customer = "Dave";
order.PaymentMethod = PaymentMethods.cash;
order3.Beverages = new List<Beverage> { new Beverage(BeveragesMenu.Soda, 3) };
order3.Beverages = new List<Beverage> { new Beverage(BeveragesMenu.Beer, 2) };
italianRestaurant.ReceiveOrder(order3);
//order 4
var order4 = new Order();
order4.Customer = "Roy";
order.PaymentMethod = PaymentMethods.card;
order4.Dishes = new List<Dish> { new Dish(DishesMenu.Lasagna, 1), new Dish(DishesMenu.Spaghetti, 1) };
order4.Beverages = new List<Beverage> { new Beverage(BeveragesMenu.Wine, 1), new Beverage(BeveragesMenu.Soda, 1) };
italianRestaurant.ReceiveOrder(order4);
//order 5
var order5 = new Order();
order5.Customer = "Lita";
order.PaymentMethod = PaymentMethods.card;
order5.Dishes = new List<Dish> { new Dish(DishesMenu.Lasagna, 3), new Dish(DishesMenu.Calzone, 1) };
order5.Beverages = new List<Beverage> { new Beverage(BeveragesMenu.Beer, 2), new Beverage(BeveragesMenu.Wine, 1) };
italianRestaurant.ReceiveOrder(order5);