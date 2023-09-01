namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public abstract class Duck
{
    public FlyBehaviour flyBehaviour;
    public QuackBehaviour quackBehaviour;

    public Duck()
    {
        
    }
    public abstract void display();
    public void performQuack()
    {
        quackBehaviour.quack();
    }

    public void performFly()
    {
        flyBehaviour.fly();
    }
    public void swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
    public void setFlyBehaviour(FlyBehaviour fb)
    {
        flyBehaviour = fb;
    }
    
    public void setQuackBehaviour(QuackBehaviour qb)
    {
        quackBehaviour = qb;
    }
}