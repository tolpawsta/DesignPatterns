using SimUDuckLibrary.Interfaces;
using static System.Console;
namespace SimUDuckLibrary.Models.DuckModels
{
    public class Duck
    {
        public IFlyable Flyable { get; set; }
        public IQuackable Quackable { get; set; }

        public void Swim()
        {
            WriteLine("Swim, swim, swim ...");
        }
        public virtual string Display() { return "I'm duck!"; }

        public string Fly()
        {
            return Flyable.Fly();
        }
        public string Quack()
        {
            return Quackable.Quack();
        }
    }
}