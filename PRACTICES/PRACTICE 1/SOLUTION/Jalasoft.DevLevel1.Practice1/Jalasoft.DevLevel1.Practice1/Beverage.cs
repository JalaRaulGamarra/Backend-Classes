namespace Jalasoft.DevLevel1.Practice1
{
    public class Beverage
    {
        private double winePrice = 9;
        private double beerPrice = 7.5;
        private double sodaPrice = 6.5;
        public BeveragesMenu Name { get; set; }
        public byte BeverageCount { get; set; }
        public double TotalPrice { get; set; }

        public Beverage(BeveragesMenu name, byte beverageCount)
        {
            Name = name;
            BeverageCount = beverageCount;
            TotalPrice = GetBeveragePrice(name) * beverageCount;
        }

        public double WinePrice
        {
            get
            {
                return winePrice;
            }
        }
        public double BeerPrice
        {
            get
            {
                return beerPrice;
            }
        }
        public double SodaPrice
        {
            get
            {
                return sodaPrice;
            }
        }

        private double GetBeveragePrice(BeveragesMenu name)
        {
            double price = 0;
            switch (name)
            {
                case BeveragesMenu.Wine:
                    price = WinePrice;
                    break;
                case BeveragesMenu.Beer:
                    price = BeerPrice;
                    break;
                case BeveragesMenu.Soda:
                    price = SodaPrice;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price;
        }
    }
}