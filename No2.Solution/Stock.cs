using System;

namespace No2.Solution
{
    public class Stock
    {
        private readonly StockInfo _stocksInfo;

        private readonly Random _rnd = new Random();

        public Stock()
        {
            _stocksInfo = new StockInfo();
        }

        public void Market()
        {
            _stocksInfo.USD = _rnd.Next(20, 40);
            _stocksInfo.Euro = _rnd.Next(30, 50);
            OnMarketCompleted(new MarketEventArgs(_stocksInfo));
        }

        public event EventHandler<MarketEventArgs> MarketCompleted;

        protected virtual void OnMarketCompleted(MarketEventArgs e) => MarketCompleted?.Invoke(this, e);
    }


}
