using System;
namespace fmsServer
{
    public class Stock
    {
        public int Id { get; set; }
        public decimal LatestQuote { get; set; }

        public Stock(int id, int latestQuote)
        {
            Id = id;
            LatestQuote = latestQuote;
        }
    }
}
