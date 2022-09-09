using fmsServer;

Random r = new Random();
List<Stock> stocks = new List<Stock>();
int indexCount = 0;
List<Stock> indexList = new List<Stock>();

for (int i = 1000; i < 1100; i++)
{
    Stock stock = new Stock(i, r.Next(50, 200));

    if (indexCount < 10)
    {
        indexList.Add(stock);
        indexCount++;
    }

    stocks.Add(stock);
}

StockIndex marketIndex = new StockIndex(1, stocks);
StockIndex top10Index = new StockIndex(2, indexList, true);
StockPriceQuoteService quoteService = new StockPriceQuoteService(marketIndex, stocks);
IndexPriceQuoteService averagePriceService = new IndexPriceQuoteService(top10Index, indexList);
Console.ReadKey();
