using static System.Console;
using SimUDuckLibrary.Models.DuckModels;

namespace SimUDuckApp
{
    public class ConsoleView
    {
        public void Info(Duck duck)
        {
            WriteLine(duck.Display());
            WriteLine(duck.Quack());
            duck.Swim();
            WriteLine(duck.Fly());
        }
    }
}