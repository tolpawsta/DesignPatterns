using StarbuzzCoffeeLibrary.Interfaces;

namespace StarbuzzCoffeeLibrary.Models.CondimentDecorators
{
    public class Whip : ICondimentDecorator
    {
        private IBeverage _beverage;
        private decimal _cost;

        public Whip(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description+$",\n Whip - \t{_cost:C}";

        public decimal Cost { get => _beverage.Cost+_cost; set => _cost=value; }
    }
}