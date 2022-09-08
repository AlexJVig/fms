using fmsServer;

Random r = new Random();
List<Stock> stocks = new List<Stock>();

for (int i = 1000; i < 1100; i++)
{
    stocks.Add(new Stock(i, r.Next(50, 200)));
}

StockIndex index = new StockIndex(0, stocks);
int a = 2 + 2;
