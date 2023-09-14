using ObserverPattern.TradingApp;

namespace DesignPatternTests;

public class UnitTest1
{
    [Fact]
    public void AssertObserverPattern()
    {
        Crypto? crypto = new Crypto("BTC","USDT");
        Algorithm algorithm = new Algorithm();
        Binance binance = new Binance();
        MetaTrader metaTrader = new MetaTrader();

        binance.Add(algorithm);
        binance.Add(metaTrader);

        crypto.LatestHigh = 10000;
        binance.Notify(crypto);
        crypto.LatestLow = 9000;
        binance.Notify(crypto);
        Assert.Equal(2,binance.Observers.Count);
        Assert.Equal(10000,algorithm.Asset!.LatestHigh);
        Assert.Equal(9000,algorithm.Asset!.LatestLow);
    }
}