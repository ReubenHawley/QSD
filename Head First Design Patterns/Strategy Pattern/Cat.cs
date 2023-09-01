namespace Head_First_Design_Patterns.Strategy_Pattern;

public class Cat
{
    public void makeSound()
    {
        meow();
    }
    
    public void meow()
    {
        Console.WriteLine("Meow meow");
    }
}