using StarbuzzCoffeeLibrary.Interfaces;

namespace StarbuzzCoffeeLibrary.Models.Beverage
{
    public class Espresso : IBeverage
    {
        public string Description => "Espresso";

        public decimal Cost { get; set; } = 1.99M;
    }
}
