using StarbuzzCoffeeLibrary.Interfaces;

namespace StarbuzzCoffeeLibrary.Models.CondimentDecorators
{
    public class Mocha : ICondimentDecorator
    {
        private decimal _cost;
        private IBeverage _beverage;

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description + $",\n Mocha - \t{_cost:C}";

        public decimal Cost
        {
            get => _beverage.Cost + _cost;
            set => _cost = value;
        }
    }
}
