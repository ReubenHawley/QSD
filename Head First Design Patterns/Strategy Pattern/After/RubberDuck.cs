namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class RubberDuck : Duck
{
    FlyBehaviour flyBehaviour;
    QuackBehaviour quackBehaviour;

    public RubberDuck()
    {
        flyBehaviour = new FlyNoWay();
        quackBehaviour = new MuteQuack();
    }

    public override void display()
    {
        Console.WriteLine("I'm a rubber duck");
    }
}