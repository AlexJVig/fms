using System;

namespace fmsServer
{
    public class StockPriceQuoteService
    {
        private List<Stock> _market;
        private IStockIndex _index;
        private Timer _timer;
        private Random random = new Random();

        public StockPriceQuoteService(IStockIndex index1, List<Stock> market)
        {
            _index = index1;
            _market = market;
            _timer = new Timer(RefreshQuotes, null, 0, 1_000);
        }

        public void RefreshQuotes(object? state)
        {
            int stocksToRefresh = random.Next(_market.Count);
            List<Stock> updatedQuotes = new List<Stock>();
            Dictionary<int, Stock> updatedDictionary = new Dictionary<int, Stock>();

            for (int i = 0; i < stocksToRefresh; i++)
            {
                int id;

                do
                {
                    id = random.Next(1_000, 1_100);
                }
                while (updatedDictionary.ContainsKey(id));

                double quote = random.Next(300) + random.NextDouble();
                Stock stock = new Stock(id, quote);
                updatedQuotes.Add(stock);
                updatedDictionary[id] = stock;
            }

            _index.UpdateStocks(updatedQuotes);
            PrintQuotes();
        }

        private void PrintQuotes()
        {
            //Console.Clear();

            foreach (var stock in _market)
            {
                Console.WriteLine($"Symbol: {stock.Id} Latest Quote: {stock.LatestQuote}");
            }
        }
    }
}
