using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice1
{
    internal struct Dish
    {
        private double pizzaPrice = 8;
        private double lasagnaPrice = 12.99;
        private double spaghettiPrice = 10.99;
        private double calzonePrice = 6;
        public DishesMenu Name { get; set; }
        public byte DishCount { get; set; }
        public double TotalPrice { get; set; }
        public double PizzaPrice 
        { 
            get 
            {
                return pizzaPrice;
            } 
        }
        public double LasagnaPrice 
        {
            get
            {
                return lasagnaPrice;
            }
        }
        public double SpaghettiPrice
        {
            get
            {
                return spaghettiPrice;
            }
        }
        public double CalzonePrice 
        {
            get
            {
                return calzonePrice;
            }
        }

        public Dish(DishesMenu name, byte dishCount)
        {
            Name = name;
            DishCount = dishCount;
            TotalPrice = GetDishPrice(name) * dishCount;
        }

        private double GetDishPrice(DishesMenu name)
        {
            double price = 0;
            switch (name)
            {
                case DishesMenu.Pizza: 
                    price = PizzaPrice;
                    break;
                case DishesMenu.Lasagna:
                    price = LasagnaPrice;
                    break;
                case DishesMenu.Calzone:
                    price = CalzonePrice;
                    break;
                case DishesMenu.Spaghetti:
                    price = SpaghettiPrice;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price;
        }
    }
}
