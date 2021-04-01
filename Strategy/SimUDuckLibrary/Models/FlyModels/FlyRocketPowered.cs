using SimUDuckLibrary.Interfaces;

namespace SimUDuckLibrary.Models.FlyModels
{
    public class FlyRocketPowered : IFlyable
    {
        public string Fly()
        {
            return "I'm flying with a rocket.";
        }
    }
}