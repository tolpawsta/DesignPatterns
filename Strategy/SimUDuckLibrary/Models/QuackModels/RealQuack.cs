using SimUDuckLibrary.Interfaces;

namespace SimUDuckLibrary.Models.QuackModels
{
    public class RealQuack : IQuackable
    {
        public string Quack()
        {
            return "Quack, quack, ...";
        }
    }
}