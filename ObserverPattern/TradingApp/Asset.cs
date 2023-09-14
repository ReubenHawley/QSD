namespace ObserverPattern.TradingApp;

public abstract class Asset
{
    public string BaseCurrency { get; set; }
    public string QuoteCurrency { get; set; }
    public decimal LatestPrice { get; set; }
    public decimal LatestVolume { get; set; }
    public decimal LatestBid { get; set; }
    public decimal LatestAsk { get; set; }
    public decimal LatestHigh { get; set; }
    public decimal LatestLow { get; set; }
    public decimal LatestOpen { get; set; }

    public Asset(string baseCurrency,string quoteCurrency)
    {
        BaseCurrency = baseCurrency;
        QuoteCurrency = quoteCurrency;
        LatestBid = 0;
        LatestAsk = 0;
        LatestHigh = 0;
        LatestLow = 0;
        LatestOpen = 0;
        LatestPrice = 0;
        LatestVolume = 0;
    }
    
}