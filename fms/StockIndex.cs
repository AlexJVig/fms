using System;
namespace fmsServer
{
    public class StockIndex : IStockIndex
    {
        public int Id { get; set; }
        public double IndexPriceAverageQuote { get; set; }
        public DateTime LastQuoteTimestamp { get; set; }
        public List<Stock> stockList { get; }
        private Dictionary<int, Stock> stockDictionarry { get; set; }

        public StockIndex(int id, List<Stock> stocks)
        {
            Id = id;
            stockList = stocks;
            stockDictionarry = new Dictionary<int, Stock>();

            foreach (var stock in stocks)
            {
                stockDictionarry.Add(stock.Id, stock);
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

        public void UpdateIndexPriceAverageQuote()
        {
            double sum = 0;

            foreach (var stock in stockList)
            {
                sum += stock.LatestQuote;
            }

            IndexPriceAverageQuote = sum / stockList.Count;
            LastQuoteTimestamp = DateTime.Now;
        }
    }
}
