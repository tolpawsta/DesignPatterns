namespace StarbuzzCoffeeLibrary.Interfaces
{
    public interface IBeverage
    {
        string Description { get; }

        decimal Cost { get; set; }
    }
}
