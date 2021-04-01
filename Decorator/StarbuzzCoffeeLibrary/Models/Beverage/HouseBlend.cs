using StarbuzzCoffeeLibrary.Interfaces;

namespace StarbuzzCoffeeLibrary.Models.Beverage
{
    public class HouseBlend : IBeverage
    {
        public string Description { get; set; } = "House Blend Coffe";

        public decimal Cost { get; set; } = .89M;
    }
}
