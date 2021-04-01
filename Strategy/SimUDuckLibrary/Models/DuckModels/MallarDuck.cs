
using SimUDuckLibrary.Interfaces;
using SimUDuckLibrary.Models.FlyModels;
using SimUDuckLibrary.Models.QuackModels;

namespace SimUDuckLibrary.Models.DuckModels
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Flyable = new FlyWithWings();
            Quackable = new RealQuack();
        }
        public override string Display()
        {
            return base.Display() + " I'm the Mallar duck.";
        }
    }
}