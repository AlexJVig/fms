using fmsServer;

Random r = new Random();
List<Stock> stocks = new List<Stock>();

for (int i = 1000; i < 1100; i++)
{
    stocks.Add(new Stock(i, r.Next(50, 200)));
}

StockIndex marketIndex = new StockIndex(0, stocks);
StockPriceQuoteService quoteService = new StockPriceQuoteService(marketIndex, stocks);
Console.ReadKey();
