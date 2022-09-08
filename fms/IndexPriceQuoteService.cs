using System;
namespace fmsServer
{
    public class IndexPriceQuoteService
    {
        private IStockIndex _index;

        public IndexPriceQuoteService(IStockIndex index1)
        {
            _index = index1;
        }
    }
}
