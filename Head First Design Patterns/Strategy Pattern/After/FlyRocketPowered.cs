namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class FlyRocketPowered : FlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("Whoooooooosh! im flying like a rocket");
    }
}