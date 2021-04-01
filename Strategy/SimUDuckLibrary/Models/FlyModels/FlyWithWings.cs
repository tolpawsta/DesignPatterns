using SimUDuckLibrary.Interfaces;

namespace SimUDuckLibrary.Models.FlyModels
{
    public class FlyWithWings : IFlyable
    {
        public string Fly()
        {
            return "Fly with wings.";
        }
    }
}