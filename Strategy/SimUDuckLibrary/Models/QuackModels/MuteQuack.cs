using SimUDuckLibrary.Interfaces;

namespace SimUDuckLibrary.Models.QuackModels
{
    public class MuteQuack : IQuackable
    {
        public string Quack()
        {
            return "I can't quack.";
        }
    }
}