using System;
using System.ComponentModel;

namespace fmsServer
{
    public class StockIndex : IStockIndex
    {
        public int Id { get; set; }
        public double IndexPriceAverageQuote { get; set; }
        public DateTime LastQuoteTimestamp { get; set; }
        public List<Stock> stockList { get; }
        private Dictionary<int, Stock> stockDictionarry { get; set; }

        public StockIndex(int id, List<Stock> stocks, bool calculateAverage = false)
        {
            Id = id;
            stockList = stocks;
            stockDictionarry = new Dictionary<int, Stock>();

            foreach (var stock in stocks)
            {
                stockDictionarry.Add(stock.Id, stock);
            }

            if (calculateAverage)
            {
                foreach (var stock in stocks)
                {
                    stock.PropertyChanged += CalculateIndexAverage;
                }
            }
        }

        public void UpdateStocks(List<Stock> stocks)
        {
            foreach (var stock in stocks)
            {
                stockDictionarry[stock.Id].LastUpdateTimestamp = DateTime.Now;
                stockDictionarry[stock.Id].LatestQuote = stock.LatestQuote;
            }
        }

        public void CalculateIndexAverage(object? sender, PropertyChangedEventArgs e)
        {
            Task.Run(() =>
            {
                double sum = 0;

                foreach (var stock in stockList)
                {
                    sum += stock.LatestQuote;
                }

                Console.WriteLine($"The index average price is: {sum / stockList.Count}");
            });
        }
    }
}
