namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class Quack : QuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("Quack quack");
    }
}