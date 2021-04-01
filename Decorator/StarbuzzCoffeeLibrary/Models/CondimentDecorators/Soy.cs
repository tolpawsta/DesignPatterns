using StarbuzzCoffeeLibrary.Interfaces;

namespace StarbuzzCoffeeLibrary.Models.CondimentDecorators
{
    public class Soy : ICondimentDecorator
    {
        private IBeverage _beverage;
        private decimal _cost;

        public Soy(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description+", Soy";

        public decimal Cost { get => _beverage.Cost+_cost; set => _cost=value; }
    }
}