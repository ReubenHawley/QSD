namespace DecoratorPattern.Coffee;

public class Coffee
{
    public double BasePrice { get; set; }
    public string Description { get; set; }
    public Size Volume { get; set; }
    public List<IIngredient> AddOns { get; set; } = new List<IIngredient>();

    public Coffee(double basePrice,string description)
    {
        BasePrice = basePrice;
        Description = description;
        Volume = Size.Mucho;
    }
    
    public virtual double GetPrice()
    {
        double price = BasePrice * (int)Volume;
        foreach (var addOn in AddOns)
        {
            price += addOn.GetPrice();
        }

        return price;
    }
    
    public virtual string GetDescription()
    {
        string description = Description;
        foreach (var addOn in AddOns)
        {
            description += $", {addOn.GetType().Name}";
        }

        return description;
    }
    
    public virtual void Add(IIngredient ingredient)
    {
        AddOns.Add(ingredient);
    }
}