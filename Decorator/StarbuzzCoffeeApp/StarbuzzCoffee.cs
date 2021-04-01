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
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);

            // add Soy
            beverage = new Soy(beverage);

            // add Whip
            beverage = new Whip(beverage);

            view.Show (beverage);
        }
    }
}
