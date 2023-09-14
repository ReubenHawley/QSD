namespace DecoratorPattern.Coffee;

public class Syrup : IIngredient
{
    public double Price { get; set; }

    public Syrup()
    {
        Price = 0.5;
    }
}