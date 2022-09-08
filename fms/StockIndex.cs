using System;
namespace fmsServer
{
    public class StockIndex
    {
        public int Id { get; set; }
        public double LatestQuote { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }
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
    }
}
