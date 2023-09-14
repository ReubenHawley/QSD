namespace DecoratorPattern.Base;

public class ConcreteDecorator : IDecorator
{
    public IComponent Component { get; set; }
    
    public ConcreteDecorator(IComponent component)
    {
        Component = component;
    }
}