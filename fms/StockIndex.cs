using System;
namespace fmsServer
{
    public class Index
    {
        public int Id { get; set; }
        public double LatestQuote { get; set; }
        public List<Stock> Stocks { get; set; }

        public Index(int id, double latestQuote, List<Stock> stocks)
        {
            Id = id;
            LatestQuote = latestQuote;
            Stocks = stocks;
        }
    }
}
