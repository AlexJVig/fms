using System;

namespace fmsServer
{
    public class IndexPriceQuoteService
    {
        private List<Stock> _stocks;
        private IStockIndex _index;

        public IndexPriceQuoteService(IStockIndex index1, List<Stock> stocks)
        {
            _index = index1;
            _stocks = stocks;
        }

        public void CalculateIndexAverage(object? state)
        {
            double sum = 0;

            foreach (var stock in _stocks)
            {
                sum += stock.LatestQuote;
            }

            Console.WriteLine($"The index average price is: {sum / _stocks.Count}");
        }
    }
}
