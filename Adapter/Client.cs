namespace Adapter;

public class Client
{
    private IClient client;

    public Client(IClient client)
    {
        this.client = client;
    }

    public void ExecuteMethod(string data)
    {
        client.Convert(data);
    }
}