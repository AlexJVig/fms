using System;
namespace fmsServer
{
    public interface IStockIndex
    {
        public void UpdateStocks(List<Stock> stocks);
    }
}
