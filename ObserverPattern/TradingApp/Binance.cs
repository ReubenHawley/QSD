namespace ObserverPattern.TradingApp;

public class Binance
{
    public List<IObserver> Observers { get; set; }

    public Binance()
    {
        Observers = new List<IObserver>();
    }

    public void Add(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void Notify(Asset? asset)
    {
        foreach (var observer in Observers)
        {
            observer.Update(asset);
        }
    }
}