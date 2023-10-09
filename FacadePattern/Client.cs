namespace FacadePattern;

public class Client
{
    public static void Main(Facade facade)
    {
        Console.WriteLine(facade.Operation());
    }
}