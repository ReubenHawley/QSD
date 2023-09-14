namespace ObserverPattern.TradingApp;

public class MetaTrader : IObserver
{
    public Asset? Asset { get; set; }

    public void Update(Asset? asset)
    {
        this.Asset = asset;
        Console.WriteLine($"MetaTrader: Listening for a new high");
        if (asset!.LatestLow > 10000) Console.WriteLine($"MetaTrader: Reacted to the {asset.LatestHigh}.");
    }
}