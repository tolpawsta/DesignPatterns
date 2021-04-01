using SimUDuckLibrary.Models.FlyModels;
using SimUDuckLibrary.Models.QuackModels;
using static System.Console;
namespace SimUDuckLibrary.Models.DuckModels
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            Flyable = new FlyNoWay();
            Quackable = new Squeak();
        }
        public override string Display()
        {
            return base.Display() + " I'm the Rubber duck.";
        }
    }
}