namespace DecoratorPattern.Coffee;

public interface IIngredient
{
    public Double Price { get; set; }
    
    public double GetPrice()
    {
        return Price;
    }
}