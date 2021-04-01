using static System.Console;
namespace SimUDuckLibrary.Models.DuckModels
{
    public class RedHeadDuck : Duck
    {
        public override string Display()
        {
            return base.Display() + " I'm the RedHead duck.";
        }
    }
}