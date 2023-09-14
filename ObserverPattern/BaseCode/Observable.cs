namespace ObserverPattern.BaseCode;

public class Observable
{
    public List<Observer> Observers { get; set; } = new List<Observer>();

    public void Add(Observer observer)
    {
        Observers.Add(observer);
    }

    public void Remove(Observer observer)
    {
        Observers.Remove(observer);
    }

    public void Notify(ISubject subject)
    {
        foreach (var observer in Observers)
        {
            observer.Update(subject);
        }
    }
}