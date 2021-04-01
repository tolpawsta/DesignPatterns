using StarbuzzCoffeeLibrary.Interfaces;

using static System.Console;

namespace StarbuzzCoffeeApp
{
    public class ConsoleView
    {
        public void Show(IBeverage beverage)
        {
            WriteLine($"{beverage.Description} - ${beverage.Cost}");
        }
    }
}
