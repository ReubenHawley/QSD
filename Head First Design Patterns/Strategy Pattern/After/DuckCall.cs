namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class DuckCall : QuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("im not a duck but i sound like one");
    }
}