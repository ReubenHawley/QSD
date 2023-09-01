namespace Head_First_Design_Patterns.Strategy_Pattern;

public class Dog : Animal
{
    public void makeSound()
    {
        bark();
    }
    
    public void bark()
    {
        Console.WriteLine("Woof woof");
    }
}