using System;

namespace No2.Solution
{
    public class MarketEventArgs : EventArgs
    {
        public MarketEventArgs(StockInfo info)
        {
            USD = info.USD;
            Euro = info.Euro;
        }

        public int USD { get; set; }
        public int Euro { get; set; }
    }
}
