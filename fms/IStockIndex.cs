using System;
namespace fmsServer
{
    public interface IStockIndex
    {
        public void UpdateStocks(List<Stock> stocks);
        public void UpdateIndexPriceAverageQuote();
    }
}
