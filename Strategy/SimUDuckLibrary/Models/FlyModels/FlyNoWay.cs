using SimUDuckLibrary.Interfaces;

namespace SimUDuckLibrary.Models.FlyModels
{
    public class FlyNoWay : IFlyable
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}