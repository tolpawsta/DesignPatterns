using System.Collections.Generic;
using StarbuzzCoffeeLibrary.Interfaces;
using StarbuzzCoffeeLibrary.Models.Beverage;

namespace StarbuzzCoffeeLibrary.Providers
{
    public class BeverageProvider
    {
        public static List<IBeverage> GetBeverages()
        {
            return new List<IBeverage>()
            {
                new Espresso() { Cost = 1.60M },
                new HouseBlend() { Cost = 2.0M }
            };
        }
    }
}
