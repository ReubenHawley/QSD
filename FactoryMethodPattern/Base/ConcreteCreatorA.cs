namespace FactoryMethodPattern.Base;

public class ConcreteCreatorA : Creator
{
    public override IProduct SomeOperation()
    {
        throw new NotImplementedException();
    }
}