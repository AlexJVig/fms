using System;
using System.Timers;

namespace fmsServer
{
    public class IndexPriceQuoteService
    {
        private List<Stock> _market;
        private IStockIndex _index;
        private System.Timers.Timer _timer;
        private Random random = new Random();

        public IndexPriceQuoteService(IStockIndex index1, List<Stock> market)
        {
            _index = index1;
            _market = market;
            _timer = new System.Timers.Timer(1_000);
            _timer.Elapsed += RefreshQuotes;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        public void RefreshQuotes(Object source, ElapsedEventArgs e)
        {

        }
    }
}
