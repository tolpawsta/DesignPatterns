using StarbuzzCoffeeLibrary.Interfaces;

using static System.Console;

namespace StarbuzzCoffeeApp
{
    public class ConsoleView
    {
        /// <summary>
        /// Write beverage info to Console
        /// </summary>
        /// <param name="beverage">beverage instanse</param>
        public void Show(IBeverage beverage)
        {
            WriteLine($"{beverage.Description} - ${beverage.Cost}");
        }
    }
}
