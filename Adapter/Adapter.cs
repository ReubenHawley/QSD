namespace Adapter;

public class Adapter : IClient
{
    private readonly Service adaptee;

    public Adapter(Service adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Convert(string xml)
    {
        adaptee.Method(xml);
    }
}