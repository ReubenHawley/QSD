namespace Head_First_Design_Patterns.Strategy_Pattern.After;

public class Person
{
    QuackBehaviour quackBehaviour;
    
    public Person()
    {
        quackBehaviour = new DuckCall();    
    }
    public void performQuack()
    {
        quackBehaviour.quack();
    }
}