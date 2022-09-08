using System;
namespace fmsServer
{
    public class Stock
    {
        public int Id { get; set; }
        public double LatestQuote { get; set; }
        public DateTime LastUpdateTimestamp { get; set; }

        public Stock(int id, int latestQuote)
        {
            Id = id;
            LatestQuote = latestQuote;
            LastUpdateTimestamp = DateTime.Now;
        }
    }
}
