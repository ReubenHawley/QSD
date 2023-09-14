// See https://aka.ms/new-console-template for more information

using ObserverPattern.TradingApp;

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