using SimUDuckLibrary.Models.FlyModels;
using SimUDuckLibrary.Models.QuackModels;

namespace SimUDuckLibrary.Models.DuckModels
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            Flyable = new FlyNoWay();
            Quackable = new RealQuack();
        }
        public override string Display()
        {
            return base.Display() + "I'm not real duck.";
        }
    }
}