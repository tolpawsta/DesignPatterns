using System;
using System.Linq;
using StarbuzzCoffeeLibrary.Models.CondimentDecorators;
using StarbuzzCoffeeLibrary.Providers;

namespace StarbuzzCoffeeApp
{
    class StarbuzzCoffee
    {
        static void Main(string[] args)
        {
            var view = new ConsoleView();
            var beverages = BeverageProvider.GetBeverages();

            // create beverage
            var beverage = beverages.Take(1).FirstOrDefault();

            // add CondimentDecorators
            // add Mocha
            beverage = new Mocha(beverage) { Cost = .60M };
            beverage = new Mocha(beverage) { Cost = .60M };

            // add Soy
            beverage = new Soy(beverage) { Cost = .40M };

            // add Whip
            beverage = new Whip(beverage) { Cost = .45M };

            view.Show (beverage);
        }
    }
}
