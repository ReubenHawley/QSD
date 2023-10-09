namespace FactoryMethodPattern.Base;

public class ConcreteCreatorB: Creator
{
    public override IProduct SomeOperation()
    {
        throw new NotImplementedException();
    }
}