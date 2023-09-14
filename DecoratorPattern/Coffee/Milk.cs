namespace DecoratorPattern.Coffee;

public class Milk : IIngredient
{
    public Double Price { get; set; }
    
    public Milk()
    {
        Price = 0.5;
    }
    
    public double GetPrice()
    {
        return Price;
    }
}