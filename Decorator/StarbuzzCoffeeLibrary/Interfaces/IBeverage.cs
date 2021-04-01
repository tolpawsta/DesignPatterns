namespace StarbuzzCoffeeLibrary.Interfaces
{
    public interface IBeverage
    {
        string Description { get; set; }

        decimal Cost { get; set; }
    }
}
