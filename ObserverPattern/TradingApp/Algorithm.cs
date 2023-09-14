namespace ObserverPattern.TradingApp;

public class Algorithm : IObserver
{
    public Asset? Asset { get; set; }
    public void Update(Asset? asset)
    {
        this.Asset = asset;
        Console.WriteLine($"Algorithm: Listening for a new low");
        if (asset!.LatestLow < 10000 && asset.LatestLow != 0)
        {
            Console.WriteLine($"Algorithm: Reacted to {asset.LatestLow}.");
        }
    }
}