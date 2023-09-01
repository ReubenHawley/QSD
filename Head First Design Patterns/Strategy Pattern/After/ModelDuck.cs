namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehaviour = new FlyNoWay();
        quackBehaviour = new Quack();
    }
    public override void display()
    {
        Console.WriteLine("I'm a model duck");
    }
}