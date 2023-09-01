namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class FlyNoWay : FlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I can't fly");
    }
}