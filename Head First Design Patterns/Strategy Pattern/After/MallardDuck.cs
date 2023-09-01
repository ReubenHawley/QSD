namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehaviour = new Quack();
        flyBehaviour = new FlyWithWings();
    }
    public override void display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}