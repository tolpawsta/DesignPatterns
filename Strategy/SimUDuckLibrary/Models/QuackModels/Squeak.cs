using SimUDuckLibrary.Interfaces;

namespace SimUDuckLibrary.Models.QuackModels
{
    public class Squeak : IQuackable
    {
        public string Quack()
        {
            return "Squeak, squeak, ...";
        }
    }
}