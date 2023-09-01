namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class MiniDuckSimulator
{
    public static void Main(string[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.performQuack();
        mallard.performFly();
    }
}