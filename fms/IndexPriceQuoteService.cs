using System;

namespace fmsServer
{
    public class IndexPriceQuoteService
    {
        private List<Stock> _market;
        private IStockIndex _index;
        private Timer _timer;
        private Random random = new Random();

        public IndexPriceQuoteService(IStockIndex index1, List<Stock> market)
        {
            _index = index1;
            _market = market;
            _timer = new Timer(CalculateIndexAverage, null, 0, 1_000);
        }

        public void CalculateIndexAverage(object? state)
        {

        }
    }
}
