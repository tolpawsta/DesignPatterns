using StarbuzzCoffeeLibrary.Interfaces;

namespace StarbuzzCoffeeLibrary.Models.Beverage
{
    public class HouseBlend : IBeverage
    {
        public string Description => $"House Blend Coffe - \t{Cost:C}";

        public decimal Cost { get; set; } = .89M;
    }
}
